using System.Collections;
using Godot;

namespace UI.BottomTips;

/// <summary>
/// 底部提示面板
/// </summary>
public partial class BottomTipsPanel : BottomTips
{
    private long _id = -1;
    
    private float _offsetY;
    //动画播放时间
    private float _animationTime = 0.5f;
    //动画移动的像素
    private int _movePixel = 153;

    public override void OnCreateUi()
    {
        _offsetY = L_Panel.Instance.Position.Y - (Position.Y + Size.Y);
    }
    

    /// <summary>
    /// 执行入场流程
    /// </summary>
    public void PlayInStep(Texture2D icon, string message)
    {
        if (_id >= 0)
        {
            StopCoroutine(_id);
            HideUi();
        }
        SetIcon(icon);
        SetMessage(message);
        _id = StartCoroutine(RunAnimation());
        ShowUi();
    }

    /// <summary>
    /// 设置图标
    /// </summary>
    public void SetIcon(Texture2D icon)
    {
        S_TextureRect.Instance.Texture = icon;
    }
    
    /// <summary>
    /// 设置文本内容
    /// </summary>
    public void SetMessage(string message)
    {
        S_Label.Instance.Text = message;
    }

    private IEnumerator RunAnimation()
    {
        //还原位置
        var pos = L_Panel.Instance.Position;
        pos.Y = Position.Y + Size.Y + _offsetY;
        L_Panel.Instance.Position = pos;

        L_Panel.Instance.ResetSize();
        yield return 0;
        //重新计算中心点
        pos.X = Size.X / 2 - L_Panel.Instance.Size.X / 2;
        L_Panel.Instance.Position = pos;
        yield return 0;

        //向上移动
        var time = 0f;
        while (time < _animationTime)
        {
            L_Panel.Instance.Position = new Vector2(
                pos.X,
                pos.Y - Mathf.Lerp(0, _movePixel, Mathf.Min(time / _animationTime, 1))
            );
            time += (float)GetProcessDeltaTime();
            yield return 0;
        }

        yield return new WaitForSeconds(3.5f);
        
        //向下移动
        while (time > 0)
        {
            L_Panel.Instance.Position = new Vector2(
                pos.X,
                pos.Y - Mathf.Lerp(0, _movePixel, Mathf.Max(time / _animationTime, 0))
            );
            time -= (float)GetProcessDeltaTime();
            yield return 0;
        }

        HideUi();
        _id = -1;
    }
    
    private static BottomTipsPanel _instance;
    public static void Init()
    {
        _instance = UiManager.CreateUi<BottomTipsPanel>(UiManager.UiNames.BottomTips);
    }

    /// <summary>
    /// 打开Tips, 并设置图标和内容
    /// </summary>
    /// <param name="icon">显示图标</param>
    /// <param name="message">显示消息</param>
    public static void ShowTips(string icon, string message)
    {
        ShowTips(ResourceManager.Load<Texture2D>(icon), message);
    }

    /// <summary>
    /// 打开Tips, 并设置图标和内容
    /// </summary>
    /// <param name="icon">显示图标</param>
    /// <param name="message">显示消息</param>
    public static void ShowTips(Texture2D icon, string message)
    {
        _instance.PlayInStep(icon, message);
    }
}
