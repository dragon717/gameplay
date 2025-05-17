using System.Threading.Tasks;
using cs.proto;
using Godot;
using Grpc.Net.Client;
using System;

/// <summary>
/// 网络管理器，用于统一处理 gRPC 请求
/// </summary>
public partial class NetworkManager : Node
{
    // 单例引用
    private static NetworkManager _instance;
    public static NetworkManager Instance => _instance;

    // 服务器连接状态
    public enum ConnectionState
    {
        Disconnected,
        Connecting,
        Connected,
        Failed
    }

    public ConnectionState CurrentState { get; private set; } = ConnectionState.Disconnected;
    public event Action<ConnectionState> OnConnectionStateChanged;

    private GrpcChannel _channel;
    private UserService.UserServiceClient _client;
    private const string SERVER_URL = "http://localhost:50051";
    private const float RECONNECT_INTERVAL = 5.0f; // 重连间隔（秒）
    private float _reconnectTimer = 0f;

    public override void _Ready()
    {
        if (_instance != null && _instance != this)
        {
            QueueFree();
            return;
        }
        _instance = this;
        Name = "NetworkManager";
        
        // 确保节点不会被销毁
        ProcessMode = ProcessModeEnum.Always;
        
        // 尝试连接服务器
        ConnectToServer();
    }

    private async void ConnectToServer()
    {
        if (CurrentState == ConnectionState.Connecting)
            return;

        CurrentState = ConnectionState.Connecting;
        OnConnectionStateChanged?.Invoke(CurrentState);

        try
        {
            // 清理旧连接
            _channel?.Dispose();
            
            // 创建新连接
            _channel = GrpcChannel.ForAddress(SERVER_URL);
            _client = new UserService.UserServiceClient(_channel);

            // 测试连接
            var request = new C2S_GetUser { Id = 0 };
            await _client.GetUserAsync(request);

            CurrentState = ConnectionState.Connected;
            OnConnectionStateChanged?.Invoke(CurrentState);
            GD.Print("Successfully connected to server");
        }
        catch (Exception ex)
        {
            GD.PrintErr($"Failed to connect to server: {ex.Message}");
            CurrentState = ConnectionState.Failed;
            OnConnectionStateChanged?.Invoke(CurrentState);
        }
    }

    public override void _Process(double delta)
    {
        // 处理重连逻辑
        if (CurrentState == ConnectionState.Failed)
        {
            _reconnectTimer += (float)delta;
            if (_reconnectTimer >= RECONNECT_INTERVAL)
            {
                _reconnectTimer = 0f;
                ConnectToServer();
            }
        }

        // 测试连接（按空格键）
        if (Input.IsActionJustPressed("ui_accept"))
        {
            TestConnection();
        }
    }

    private async void TestConnection()
    {
        try
        {
            var user = await FetchUserAsync(1);
            if (user != null)
            {
                GD.Print($"Connection test successful. Got user ID: {user.Id}");
            }
        }
        catch (Exception ex)
        {
            GD.PrintErr($"Connection test failed: {ex.Message}");
            CurrentState = ConnectionState.Failed;
            OnConnectionStateChanged?.Invoke(CurrentState);
        }
    }

    /// <summary>
    /// 获取用户信息
    /// </summary>
    public async Task<User> FetchUserAsync(ulong userId)
    {
        if (CurrentState != ConnectionState.Connected)
        {
            throw new InvalidOperationException("Not connected to server");
        }

        try
        {
            var request = new C2S_GetUser { Id = userId };
            var response = await _client.GetUserAsync(request);
            return response.User;
        }
        catch (Exception ex)
        {
            GD.PrintErr($"Failed to fetch user: {ex.Message}");
            CurrentState = ConnectionState.Failed;
            OnConnectionStateChanged?.Invoke(CurrentState);
            throw;
        }
    }

    public override void _ExitTree()
    {
        base._ExitTree();
        if (_instance == this)
        {
            _channel?.Dispose();
            _instance = null;
        }
    }

    /// <summary>
    /// 自动添加到场景树的初始化方法
    /// </summary>
    public static void Initialize(Node parent)
    {
        if (_instance == null)
        {
            var networkManager = new NetworkManager();
            parent.AddChild(networkManager);
        }
    }
}