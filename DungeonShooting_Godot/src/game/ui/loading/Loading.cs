namespace UI.Loading;

/// <summary>
/// Ui代码, 该类是根据ui场景自动生成的, 请不要手动编辑该类, 以免造成代码丢失
/// </summary>
public abstract partial class Loading : UiBase
{
    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.ColorRect"/>, 节点路径: Loading.ColorRect
    /// </summary>
    public ColorRect L_ColorRect
    {
        get
        {
            if (_L_ColorRect == null) _L_ColorRect = new ColorRect(this, GetNodeOrNull<Godot.ColorRect>("ColorRect"));
            return _L_ColorRect;
        }
    }
    private ColorRect _L_ColorRect;

    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: Loading.Label
    /// </summary>
    public Label L_Label
    {
        get
        {
            if (_L_Label == null) _L_Label = new Label(this, GetNodeOrNull<Godot.Label>("Label"));
            return _L_Label;
        }
    }
    private Label _L_Label;


    public Loading() : base(nameof(Loading))
    {
    }

    public sealed override void OnInitNestedUi()
    {
    }

    /// <summary>
    /// 类型: <see cref="Godot.ColorRect"/>, 路径: Loading.ColorRect
    /// </summary>
    public class ColorRect : UiNode<Loading, Godot.ColorRect, ColorRect>
    {
        public ColorRect(Loading uiPanel, Godot.ColorRect node) : base(uiPanel, node) {  }
        public override ColorRect Clone() => new (UiPanel, (Godot.ColorRect)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: Loading.Label
    /// </summary>
    public class Label : UiNode<Loading, Godot.Label, Label>
    {
        public Label(Loading uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override Label Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }


    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.ColorRect"/>, 节点路径: Loading.ColorRect
    /// </summary>
    public ColorRect S_ColorRect => L_ColorRect;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Label"/>, 节点路径: Loading.Label
    /// </summary>
    public Label S_Label => L_Label;

}
