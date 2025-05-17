using System.Threading.Tasks;
using cs.proto;
using Godot;
using Grpc.Net.Client;

//example
/*
    var user = await NetworkManager.Instance.FetchUserAsync(1);
    GD.Print(user?.Name);
*/

/// <summary>
/// 网络管理器，用于统一处理 gRPC 请求
/// </summary>
public partial class NetworkManager : Node
{
    // 单例引用
    private static NetworkManager _instance;
    public static NetworkManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new NetworkManager();
                _instance.Name = "NetworkManager";
            }
            return _instance;
        }
    }

    private GrpcChannel _channel;
    private UserService.UserServiceClient _client;

    public override void _Ready()
    {
        // 初始化 gRPC 客户端
        _channel = GrpcChannel.ForAddress("http://localhost:5000");
        _client = new UserService.UserServiceClient(_channel);
    }

    /// <summary>
    /// 获取用户信息
    /// </summary>
    public async Task<User> FetchUserAsync(ulong userId)
    {
        try
        {
            var request = new C2S_GetUser { Id = userId };
            var response = await _client.GetUserAsync(request);
            return response.User;
        }
        catch (System.Exception ex)
        {
            GD.PrintErr($"Failed to fetch user: {ex.Message}");
            return null;
        }
    }

    /// <summary>
    /// 示例：按下空格键获取用户信息
    /// </summary>
    public override void _Process(double delta)
    {
        if (Input.IsActionJustPressed("ui_accept"))
        {
            FetchUserAsync(1).ContinueWith(task =>
            {
                if (task.Result != null)
                {
                    GD.Print($"Got user ID: {task.Result.Id}");
                }
            });
        }
    }

    /// <summary>
    /// 防止手动创建多个实例
    /// </summary>
    private NetworkManager()
    {
        // 构造函数私有化
    }

    /// <summary>
    /// 自动添加到场景树的初始化方法
    /// </summary>
    public static void Initialize(Node parent)
    {
        if (_instance == null)
        {
            _instance = new NetworkManager();
            parent.AddChild(_instance);
        }
    }

    public override void _ExitTree()
    {
        base._ExitTree();
        if (_instance == this)
        {
            _instance = null;
        }
    }
}