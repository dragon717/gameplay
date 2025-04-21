namespace UI.EditorTileImage;

/// <summary>
/// Ui代码, 该类是根据ui场景自动生成的, 请不要手动编辑该类, 以免造成代码丢失
/// </summary>
public abstract partial class EditorTileImage : UiBase
{
    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: EditorTileImage.HBoxContainer
    /// </summary>
    public HBoxContainer L_HBoxContainer
    {
        get
        {
            if (_L_HBoxContainer == null) _L_HBoxContainer = new HBoxContainer((EditorTileImagePanel)this, GetNode<Godot.HBoxContainer>("HBoxContainer"));
            return _L_HBoxContainer;
        }
    }
    private HBoxContainer _L_HBoxContainer;


    public EditorTileImage() : base(nameof(EditorTileImage))
    {
    }

    public sealed override void OnInitNestedUi()
    {
        _ = L_HBoxContainer.L_Left.L_Bg;
        _ = L_HBoxContainer.L_Left.L_Bg.L_TextureRoot.L_Brush;

    }

    /// <summary>
    /// 类型: <see cref="Godot.Sprite2D"/>, 路径: EditorTileImage.HBoxContainer.Left.Bg.TextureRoot.TileSprite
    /// </summary>
    public class TileSprite : UiNode<EditorTileImagePanel, Godot.Sprite2D, TileSprite>
    {
        public TileSprite(EditorTileImagePanel uiPanel, Godot.Sprite2D node) : base(uiPanel, node) {  }
        public override TileSprite Clone() => new (UiPanel, (Godot.Sprite2D)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="UI.EditorTileImage.RectBrush"/>, 路径: EditorTileImage.HBoxContainer.Left.Bg.TextureRoot.Brush
    /// </summary>
    public class Brush : UiNode<EditorTileImagePanel, UI.EditorTileImage.RectBrush, Brush>
    {
        public Brush(EditorTileImagePanel uiPanel, UI.EditorTileImage.RectBrush node) : base(uiPanel, node) {  }
        public override Brush Clone() => new (UiPanel, (UI.EditorTileImage.RectBrush)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Control"/>, 路径: EditorTileImage.HBoxContainer.Left.Bg.TextureRoot
    /// </summary>
    public class TextureRoot : UiNode<EditorTileImagePanel, Godot.Control, TextureRoot>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Sprite2D"/>, 节点路径: EditorTileImage.HBoxContainer.Left.Bg.TileSprite
        /// </summary>
        public TileSprite L_TileSprite
        {
            get
            {
                if (_L_TileSprite == null) _L_TileSprite = new TileSprite(UiPanel, Instance.GetNode<Godot.Sprite2D>("TileSprite"));
                return _L_TileSprite;
            }
        }
        private TileSprite _L_TileSprite;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="UI.EditorTileImage.RectBrush"/>, 节点路径: EditorTileImage.HBoxContainer.Left.Bg.Brush
        /// </summary>
        public Brush L_Brush
        {
            get
            {
                if (_L_Brush == null) _L_Brush = new Brush(UiPanel, Instance.GetNode<UI.EditorTileImage.RectBrush>("Brush"));
                return _L_Brush;
            }
        }
        private Brush _L_Brush;

        public TextureRoot(EditorTileImagePanel uiPanel, Godot.Control node) : base(uiPanel, node) {  }
        public override TextureRoot Clone() => new (UiPanel, (Godot.Control)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.TextureButton"/>, 路径: EditorTileImage.HBoxContainer.Left.Bg.FocusBtn
    /// </summary>
    public class FocusBtn : UiNode<EditorTileImagePanel, Godot.TextureButton, FocusBtn>
    {
        public FocusBtn(EditorTileImagePanel uiPanel, Godot.TextureButton node) : base(uiPanel, node) {  }
        public override FocusBtn Clone() => new (UiPanel, (Godot.TextureButton)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="UI.EditorTileImage.ImageBg"/>, 路径: EditorTileImage.HBoxContainer.Left.Bg
    /// </summary>
    public class Bg : UiNode<EditorTileImagePanel, UI.EditorTileImage.ImageBg, Bg>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Control"/>, 节点路径: EditorTileImage.HBoxContainer.Left.TextureRoot
        /// </summary>
        public TextureRoot L_TextureRoot
        {
            get
            {
                if (_L_TextureRoot == null) _L_TextureRoot = new TextureRoot(UiPanel, Instance.GetNode<Godot.Control>("TextureRoot"));
                return _L_TextureRoot;
            }
        }
        private TextureRoot _L_TextureRoot;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.TextureButton"/>, 节点路径: EditorTileImage.HBoxContainer.Left.FocusBtn
        /// </summary>
        public FocusBtn L_FocusBtn
        {
            get
            {
                if (_L_FocusBtn == null) _L_FocusBtn = new FocusBtn(UiPanel, Instance.GetNode<Godot.TextureButton>("FocusBtn"));
                return _L_FocusBtn;
            }
        }
        private FocusBtn _L_FocusBtn;

        public Bg(EditorTileImagePanel uiPanel, UI.EditorTileImage.ImageBg node) : base(uiPanel, node) {  }
        public override Bg Clone() => new (UiPanel, (UI.EditorTileImage.ImageBg)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Panel"/>, 路径: EditorTileImage.HBoxContainer.Left
    /// </summary>
    public class Left : UiNode<EditorTileImagePanel, Godot.Panel, Left>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="UI.EditorTileImage.ImageBg"/>, 节点路径: EditorTileImage.HBoxContainer.Bg
        /// </summary>
        public Bg L_Bg
        {
            get
            {
                if (_L_Bg == null) _L_Bg = new Bg(UiPanel, Instance.GetNode<UI.EditorTileImage.ImageBg>("Bg"));
                return _L_Bg;
            }
        }
        private Bg _L_Bg;

        public Left(EditorTileImagePanel uiPanel, Godot.Panel node) : base(uiPanel, node) {  }
        public override Left Clone() => new (UiPanel, (Godot.Panel)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.HBoxContainer.Label
    /// </summary>
    public class Label : UiNode<EditorTileImagePanel, Godot.Label, Label>
    {
        public Label(EditorTileImagePanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override Label Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.SpinBox"/>, 路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.HBoxContainer.StartX
    /// </summary>
    public class StartX : UiNode<EditorTileImagePanel, Godot.SpinBox, StartX>
    {
        public StartX(EditorTileImagePanel uiPanel, Godot.SpinBox node) : base(uiPanel, node) {  }
        public override StartX Clone() => new (UiPanel, (Godot.SpinBox)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.HBoxContainer
    /// </summary>
    public class HBoxContainer_1 : UiNode<EditorTileImagePanel, Godot.HBoxContainer, HBoxContainer_1>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.Label
        /// </summary>
        public Label L_Label
        {
            get
            {
                if (_L_Label == null) _L_Label = new Label(UiPanel, Instance.GetNode<Godot.Label>("Label"));
                return _L_Label;
            }
        }
        private Label _L_Label;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.SpinBox"/>, 节点路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.StartX
        /// </summary>
        public StartX L_StartX
        {
            get
            {
                if (_L_StartX == null) _L_StartX = new StartX(UiPanel, Instance.GetNode<Godot.SpinBox>("StartX"));
                return _L_StartX;
            }
        }
        private StartX _L_StartX;

        public HBoxContainer_1(EditorTileImagePanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override HBoxContainer_1 Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.HBoxContainer2.Label
    /// </summary>
    public class Label_1 : UiNode<EditorTileImagePanel, Godot.Label, Label_1>
    {
        public Label_1(EditorTileImagePanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override Label_1 Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.SpinBox"/>, 路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.HBoxContainer2.StartY
    /// </summary>
    public class StartY : UiNode<EditorTileImagePanel, Godot.SpinBox, StartY>
    {
        public StartY(EditorTileImagePanel uiPanel, Godot.SpinBox node) : base(uiPanel, node) {  }
        public override StartY Clone() => new (UiPanel, (Godot.SpinBox)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.HBoxContainer2
    /// </summary>
    public class HBoxContainer2 : UiNode<EditorTileImagePanel, Godot.HBoxContainer, HBoxContainer2>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.Label
        /// </summary>
        public Label_1 L_Label
        {
            get
            {
                if (_L_Label == null) _L_Label = new Label_1(UiPanel, Instance.GetNode<Godot.Label>("Label"));
                return _L_Label;
            }
        }
        private Label_1 _L_Label;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.SpinBox"/>, 节点路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.StartY
        /// </summary>
        public StartY L_StartY
        {
            get
            {
                if (_L_StartY == null) _L_StartY = new StartY(UiPanel, Instance.GetNode<Godot.SpinBox>("StartY"));
                return _L_StartY;
            }
        }
        private StartY _L_StartY;

        public HBoxContainer2(EditorTileImagePanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override HBoxContainer2 Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.HBoxContainer3.Label
    /// </summary>
    public class Label_2 : UiNode<EditorTileImagePanel, Godot.Label, Label_2>
    {
        public Label_2(EditorTileImagePanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override Label_2 Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.SpinBox"/>, 路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.HBoxContainer3.OffsetX
    /// </summary>
    public class OffsetX : UiNode<EditorTileImagePanel, Godot.SpinBox, OffsetX>
    {
        public OffsetX(EditorTileImagePanel uiPanel, Godot.SpinBox node) : base(uiPanel, node) {  }
        public override OffsetX Clone() => new (UiPanel, (Godot.SpinBox)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.HBoxContainer3
    /// </summary>
    public class HBoxContainer3 : UiNode<EditorTileImagePanel, Godot.HBoxContainer, HBoxContainer3>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.Label
        /// </summary>
        public Label_2 L_Label
        {
            get
            {
                if (_L_Label == null) _L_Label = new Label_2(UiPanel, Instance.GetNode<Godot.Label>("Label"));
                return _L_Label;
            }
        }
        private Label_2 _L_Label;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.SpinBox"/>, 节点路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.OffsetX
        /// </summary>
        public OffsetX L_OffsetX
        {
            get
            {
                if (_L_OffsetX == null) _L_OffsetX = new OffsetX(UiPanel, Instance.GetNode<Godot.SpinBox>("OffsetX"));
                return _L_OffsetX;
            }
        }
        private OffsetX _L_OffsetX;

        public HBoxContainer3(EditorTileImagePanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override HBoxContainer3 Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.HBoxContainer4.Label
    /// </summary>
    public class Label_3 : UiNode<EditorTileImagePanel, Godot.Label, Label_3>
    {
        public Label_3(EditorTileImagePanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override Label_3 Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.SpinBox"/>, 路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.HBoxContainer4.OffsetY
    /// </summary>
    public class OffsetY : UiNode<EditorTileImagePanel, Godot.SpinBox, OffsetY>
    {
        public OffsetY(EditorTileImagePanel uiPanel, Godot.SpinBox node) : base(uiPanel, node) {  }
        public override OffsetY Clone() => new (UiPanel, (Godot.SpinBox)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.HBoxContainer4
    /// </summary>
    public class HBoxContainer4 : UiNode<EditorTileImagePanel, Godot.HBoxContainer, HBoxContainer4>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.Label
        /// </summary>
        public Label_3 L_Label
        {
            get
            {
                if (_L_Label == null) _L_Label = new Label_3(UiPanel, Instance.GetNode<Godot.Label>("Label"));
                return _L_Label;
            }
        }
        private Label_3 _L_Label;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.SpinBox"/>, 节点路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.OffsetY
        /// </summary>
        public OffsetY L_OffsetY
        {
            get
            {
                if (_L_OffsetY == null) _L_OffsetY = new OffsetY(UiPanel, Instance.GetNode<Godot.SpinBox>("OffsetY"));
                return _L_OffsetY;
            }
        }
        private OffsetY _L_OffsetY;

        public HBoxContainer4(EditorTileImagePanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override HBoxContainer4 Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.HBoxContainer5.Label
    /// </summary>
    public class Label_4 : UiNode<EditorTileImagePanel, Godot.Label, Label_4>
    {
        public Label_4(EditorTileImagePanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override Label_4 Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.SpinBox"/>, 路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.HBoxContainer5.HCount
    /// </summary>
    public class HCount : UiNode<EditorTileImagePanel, Godot.SpinBox, HCount>
    {
        public HCount(EditorTileImagePanel uiPanel, Godot.SpinBox node) : base(uiPanel, node) {  }
        public override HCount Clone() => new (UiPanel, (Godot.SpinBox)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.HBoxContainer5
    /// </summary>
    public class HBoxContainer5 : UiNode<EditorTileImagePanel, Godot.HBoxContainer, HBoxContainer5>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.Label
        /// </summary>
        public Label_4 L_Label
        {
            get
            {
                if (_L_Label == null) _L_Label = new Label_4(UiPanel, Instance.GetNode<Godot.Label>("Label"));
                return _L_Label;
            }
        }
        private Label_4 _L_Label;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.SpinBox"/>, 节点路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.HCount
        /// </summary>
        public HCount L_HCount
        {
            get
            {
                if (_L_HCount == null) _L_HCount = new HCount(UiPanel, Instance.GetNode<Godot.SpinBox>("HCount"));
                return _L_HCount;
            }
        }
        private HCount _L_HCount;

        public HBoxContainer5(EditorTileImagePanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override HBoxContainer5 Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.HBoxContainer6.Label
    /// </summary>
    public class Label_5 : UiNode<EditorTileImagePanel, Godot.Label, Label_5>
    {
        public Label_5(EditorTileImagePanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override Label_5 Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.SpinBox"/>, 路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.HBoxContainer6.VCount
    /// </summary>
    public class VCount : UiNode<EditorTileImagePanel, Godot.SpinBox, VCount>
    {
        public VCount(EditorTileImagePanel uiPanel, Godot.SpinBox node) : base(uiPanel, node) {  }
        public override VCount Clone() => new (UiPanel, (Godot.SpinBox)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.HBoxContainer6
    /// </summary>
    public class HBoxContainer6 : UiNode<EditorTileImagePanel, Godot.HBoxContainer, HBoxContainer6>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.Label
        /// </summary>
        public Label_5 L_Label
        {
            get
            {
                if (_L_Label == null) _L_Label = new Label_5(UiPanel, Instance.GetNode<Godot.Label>("Label"));
                return _L_Label;
            }
        }
        private Label_5 _L_Label;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.SpinBox"/>, 节点路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.VCount
        /// </summary>
        public VCount L_VCount
        {
            get
            {
                if (_L_VCount == null) _L_VCount = new VCount(UiPanel, Instance.GetNode<Godot.SpinBox>("VCount"));
                return _L_VCount;
            }
        }
        private VCount _L_VCount;

        public HBoxContainer6(EditorTileImagePanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override HBoxContainer6 Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.VBoxContainer"/>, 路径: EditorTileImage.HBoxContainer.Right.VBoxContainer
    /// </summary>
    public class VBoxContainer : UiNode<EditorTileImagePanel, Godot.VBoxContainer, VBoxContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: EditorTileImage.HBoxContainer.Right.HBoxContainer
        /// </summary>
        public HBoxContainer_1 L_HBoxContainer
        {
            get
            {
                if (_L_HBoxContainer == null) _L_HBoxContainer = new HBoxContainer_1(UiPanel, Instance.GetNode<Godot.HBoxContainer>("HBoxContainer"));
                return _L_HBoxContainer;
            }
        }
        private HBoxContainer_1 _L_HBoxContainer;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: EditorTileImage.HBoxContainer.Right.HBoxContainer2
        /// </summary>
        public HBoxContainer2 L_HBoxContainer2
        {
            get
            {
                if (_L_HBoxContainer2 == null) _L_HBoxContainer2 = new HBoxContainer2(UiPanel, Instance.GetNode<Godot.HBoxContainer>("HBoxContainer2"));
                return _L_HBoxContainer2;
            }
        }
        private HBoxContainer2 _L_HBoxContainer2;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: EditorTileImage.HBoxContainer.Right.HBoxContainer3
        /// </summary>
        public HBoxContainer3 L_HBoxContainer3
        {
            get
            {
                if (_L_HBoxContainer3 == null) _L_HBoxContainer3 = new HBoxContainer3(UiPanel, Instance.GetNode<Godot.HBoxContainer>("HBoxContainer3"));
                return _L_HBoxContainer3;
            }
        }
        private HBoxContainer3 _L_HBoxContainer3;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: EditorTileImage.HBoxContainer.Right.HBoxContainer4
        /// </summary>
        public HBoxContainer4 L_HBoxContainer4
        {
            get
            {
                if (_L_HBoxContainer4 == null) _L_HBoxContainer4 = new HBoxContainer4(UiPanel, Instance.GetNode<Godot.HBoxContainer>("HBoxContainer4"));
                return _L_HBoxContainer4;
            }
        }
        private HBoxContainer4 _L_HBoxContainer4;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: EditorTileImage.HBoxContainer.Right.HBoxContainer5
        /// </summary>
        public HBoxContainer5 L_HBoxContainer5
        {
            get
            {
                if (_L_HBoxContainer5 == null) _L_HBoxContainer5 = new HBoxContainer5(UiPanel, Instance.GetNode<Godot.HBoxContainer>("HBoxContainer5"));
                return _L_HBoxContainer5;
            }
        }
        private HBoxContainer5 _L_HBoxContainer5;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: EditorTileImage.HBoxContainer.Right.HBoxContainer6
        /// </summary>
        public HBoxContainer6 L_HBoxContainer6
        {
            get
            {
                if (_L_HBoxContainer6 == null) _L_HBoxContainer6 = new HBoxContainer6(UiPanel, Instance.GetNode<Godot.HBoxContainer>("HBoxContainer6"));
                return _L_HBoxContainer6;
            }
        }
        private HBoxContainer6 _L_HBoxContainer6;

        public VBoxContainer(EditorTileImagePanel uiPanel, Godot.VBoxContainer node) : base(uiPanel, node) {  }
        public override VBoxContainer Clone() => new (UiPanel, (Godot.VBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Panel"/>, 路径: EditorTileImage.HBoxContainer.Right
    /// </summary>
    public class Right : UiNode<EditorTileImagePanel, Godot.Panel, Right>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: EditorTileImage.HBoxContainer.VBoxContainer
        /// </summary>
        public VBoxContainer L_VBoxContainer
        {
            get
            {
                if (_L_VBoxContainer == null) _L_VBoxContainer = new VBoxContainer(UiPanel, Instance.GetNode<Godot.VBoxContainer>("VBoxContainer"));
                return _L_VBoxContainer;
            }
        }
        private VBoxContainer _L_VBoxContainer;

        public Right(EditorTileImagePanel uiPanel, Godot.Panel node) : base(uiPanel, node) {  }
        public override Right Clone() => new (UiPanel, (Godot.Panel)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: EditorTileImage.HBoxContainer
    /// </summary>
    public class HBoxContainer : UiNode<EditorTileImagePanel, Godot.HBoxContainer, HBoxContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Panel"/>, 节点路径: EditorTileImage.Left
        /// </summary>
        public Left L_Left
        {
            get
            {
                if (_L_Left == null) _L_Left = new Left(UiPanel, Instance.GetNode<Godot.Panel>("Left"));
                return _L_Left;
            }
        }
        private Left _L_Left;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Panel"/>, 节点路径: EditorTileImage.Right
        /// </summary>
        public Right L_Right
        {
            get
            {
                if (_L_Right == null) _L_Right = new Right(UiPanel, Instance.GetNode<Godot.Panel>("Right"));
                return _L_Right;
            }
        }
        private Right _L_Right;

        public HBoxContainer(EditorTileImagePanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override HBoxContainer Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }


    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Sprite2D"/>, 节点路径: EditorTileImage.HBoxContainer.Left.Bg.TextureRoot.TileSprite
    /// </summary>
    public TileSprite S_TileSprite => L_HBoxContainer.L_Left.L_Bg.L_TextureRoot.L_TileSprite;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="UI.EditorTileImage.RectBrush"/>, 节点路径: EditorTileImage.HBoxContainer.Left.Bg.TextureRoot.Brush
    /// </summary>
    public Brush S_Brush => L_HBoxContainer.L_Left.L_Bg.L_TextureRoot.L_Brush;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Control"/>, 节点路径: EditorTileImage.HBoxContainer.Left.Bg.TextureRoot
    /// </summary>
    public TextureRoot S_TextureRoot => L_HBoxContainer.L_Left.L_Bg.L_TextureRoot;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.TextureButton"/>, 节点路径: EditorTileImage.HBoxContainer.Left.Bg.FocusBtn
    /// </summary>
    public FocusBtn S_FocusBtn => L_HBoxContainer.L_Left.L_Bg.L_FocusBtn;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="UI.EditorTileImage.ImageBg"/>, 节点路径: EditorTileImage.HBoxContainer.Left.Bg
    /// </summary>
    public Bg S_Bg => L_HBoxContainer.L_Left.L_Bg;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Panel"/>, 节点路径: EditorTileImage.HBoxContainer.Left
    /// </summary>
    public Left S_Left => L_HBoxContainer.L_Left;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.SpinBox"/>, 节点路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.HBoxContainer.StartX
    /// </summary>
    public StartX S_StartX => L_HBoxContainer.L_Right.L_VBoxContainer.L_HBoxContainer.L_StartX;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.SpinBox"/>, 节点路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.HBoxContainer2.StartY
    /// </summary>
    public StartY S_StartY => L_HBoxContainer.L_Right.L_VBoxContainer.L_HBoxContainer2.L_StartY;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.HBoxContainer2
    /// </summary>
    public HBoxContainer2 S_HBoxContainer2 => L_HBoxContainer.L_Right.L_VBoxContainer.L_HBoxContainer2;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.SpinBox"/>, 节点路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.HBoxContainer3.OffsetX
    /// </summary>
    public OffsetX S_OffsetX => L_HBoxContainer.L_Right.L_VBoxContainer.L_HBoxContainer3.L_OffsetX;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.HBoxContainer3
    /// </summary>
    public HBoxContainer3 S_HBoxContainer3 => L_HBoxContainer.L_Right.L_VBoxContainer.L_HBoxContainer3;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.SpinBox"/>, 节点路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.HBoxContainer4.OffsetY
    /// </summary>
    public OffsetY S_OffsetY => L_HBoxContainer.L_Right.L_VBoxContainer.L_HBoxContainer4.L_OffsetY;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.HBoxContainer4
    /// </summary>
    public HBoxContainer4 S_HBoxContainer4 => L_HBoxContainer.L_Right.L_VBoxContainer.L_HBoxContainer4;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.SpinBox"/>, 节点路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.HBoxContainer5.HCount
    /// </summary>
    public HCount S_HCount => L_HBoxContainer.L_Right.L_VBoxContainer.L_HBoxContainer5.L_HCount;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.HBoxContainer5
    /// </summary>
    public HBoxContainer5 S_HBoxContainer5 => L_HBoxContainer.L_Right.L_VBoxContainer.L_HBoxContainer5;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.SpinBox"/>, 节点路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.HBoxContainer6.VCount
    /// </summary>
    public VCount S_VCount => L_HBoxContainer.L_Right.L_VBoxContainer.L_HBoxContainer6.L_VCount;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: EditorTileImage.HBoxContainer.Right.VBoxContainer.HBoxContainer6
    /// </summary>
    public HBoxContainer6 S_HBoxContainer6 => L_HBoxContainer.L_Right.L_VBoxContainer.L_HBoxContainer6;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: EditorTileImage.HBoxContainer.Right.VBoxContainer
    /// </summary>
    public VBoxContainer S_VBoxContainer => L_HBoxContainer.L_Right.L_VBoxContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Panel"/>, 节点路径: EditorTileImage.HBoxContainer.Right
    /// </summary>
    public Right S_Right => L_HBoxContainer.L_Right;

}
