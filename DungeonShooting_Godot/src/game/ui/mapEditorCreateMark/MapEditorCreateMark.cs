namespace UI.MapEditorCreateMark;

/// <summary>
/// Ui代码, 该类是根据ui场景自动生成的, 请不要手动编辑该类, 以免造成代码丢失
/// </summary>
public abstract partial class MapEditorCreateMark : UiBase
{
    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.MarginContainer"/>, 节点路径: MapEditorCreateMark.MarginContainer
    /// </summary>
    public MarginContainer L_MarginContainer
    {
        get
        {
            if (_L_MarginContainer == null) _L_MarginContainer = new MarginContainer((MapEditorCreateMarkPanel)this, GetNode<Godot.MarginContainer>("MarginContainer"));
            return _L_MarginContainer;
        }
    }
    private MarginContainer _L_MarginContainer;

    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.MarginContainer"/>, 节点路径: MapEditorCreateMark.ExpandPanel
    /// </summary>
    public ExpandPanel L_ExpandPanel
    {
        get
        {
            if (_L_ExpandPanel == null) _L_ExpandPanel = new ExpandPanel((MapEditorCreateMarkPanel)this, GetNode<Godot.MarginContainer>("ExpandPanel"));
            return _L_ExpandPanel;
        }
    }
    private ExpandPanel _L_ExpandPanel;

    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="UI.MapEditorCreateMark.NumberAttribute"/>, 节点路径: MapEditorCreateMark.NumberBar
    /// </summary>
    public NumberBar L_NumberBar
    {
        get
        {
            if (_L_NumberBar == null) _L_NumberBar = new NumberBar((MapEditorCreateMarkPanel)this, GetNode<UI.MapEditorCreateMark.NumberAttribute>("NumberBar"));
            return _L_NumberBar;
        }
    }
    private NumberBar _L_NumberBar;

    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="UI.MapEditorCreateMark.OptionAttribute"/>, 节点路径: MapEditorCreateMark.OptionBar
    /// </summary>
    public OptionBar L_OptionBar
    {
        get
        {
            if (_L_OptionBar == null) _L_OptionBar = new OptionBar((MapEditorCreateMarkPanel)this, GetNode<UI.MapEditorCreateMark.OptionAttribute>("OptionBar"));
            return _L_OptionBar;
        }
    }
    private OptionBar _L_OptionBar;

    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="UI.MapEditorCreateMark.ObjectAttribute"/>, 节点路径: MapEditorCreateMark.ObjectBar
    /// </summary>
    public ObjectBar L_ObjectBar
    {
        get
        {
            if (_L_ObjectBar == null) _L_ObjectBar = new ObjectBar((MapEditorCreateMarkPanel)this, GetNode<UI.MapEditorCreateMark.ObjectAttribute>("ObjectBar"));
            return _L_ObjectBar;
        }
    }
    private ObjectBar _L_ObjectBar;


    public MapEditorCreateMark() : base(nameof(MapEditorCreateMark))
    {
    }

    public sealed override void OnInitNestedUi()
    {
        _ = L_NumberBar;
        _ = L_OptionBar;
        _ = L_ObjectBar;

    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.HBoxContainer2.PosLabel
    /// </summary>
    public class PosLabel : UiNode<MapEditorCreateMarkPanel, Godot.Label, PosLabel>
    {
        public PosLabel(MapEditorCreateMarkPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override PosLabel Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.HBoxContainer2.VBoxContainer.HBoxContainer.Label
    /// </summary>
    public class Label : UiNode<MapEditorCreateMarkPanel, Godot.Label, Label>
    {
        public Label(MapEditorCreateMarkPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override Label Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.SpinBox"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.HBoxContainer2.VBoxContainer.HBoxContainer.PosX
    /// </summary>
    public class PosX : UiNode<MapEditorCreateMarkPanel, Godot.SpinBox, PosX>
    {
        public PosX(MapEditorCreateMarkPanel uiPanel, Godot.SpinBox node) : base(uiPanel, node) {  }
        public override PosX Clone() => new (UiPanel, (Godot.SpinBox)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.HBoxContainer2.VBoxContainer.HBoxContainer
    /// </summary>
    public class HBoxContainer : UiNode<MapEditorCreateMarkPanel, Godot.HBoxContainer, HBoxContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.HBoxContainer2.VBoxContainer.Label
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
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.SpinBox"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.HBoxContainer2.VBoxContainer.PosX
        /// </summary>
        public PosX L_PosX
        {
            get
            {
                if (_L_PosX == null) _L_PosX = new PosX(UiPanel, Instance.GetNode<Godot.SpinBox>("PosX"));
                return _L_PosX;
            }
        }
        private PosX _L_PosX;

        public HBoxContainer(MapEditorCreateMarkPanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override HBoxContainer Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.HBoxContainer2.VBoxContainer.HBoxContainer2.Label
    /// </summary>
    public class Label_1 : UiNode<MapEditorCreateMarkPanel, Godot.Label, Label_1>
    {
        public Label_1(MapEditorCreateMarkPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override Label_1 Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.SpinBox"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.HBoxContainer2.VBoxContainer.HBoxContainer2.PosY
    /// </summary>
    public class PosY : UiNode<MapEditorCreateMarkPanel, Godot.SpinBox, PosY>
    {
        public PosY(MapEditorCreateMarkPanel uiPanel, Godot.SpinBox node) : base(uiPanel, node) {  }
        public override PosY Clone() => new (UiPanel, (Godot.SpinBox)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.HBoxContainer2.VBoxContainer.HBoxContainer2
    /// </summary>
    public class HBoxContainer2_1 : UiNode<MapEditorCreateMarkPanel, Godot.HBoxContainer, HBoxContainer2_1>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.HBoxContainer2.VBoxContainer.Label
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
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.SpinBox"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.HBoxContainer2.VBoxContainer.PosY
        /// </summary>
        public PosY L_PosY
        {
            get
            {
                if (_L_PosY == null) _L_PosY = new PosY(UiPanel, Instance.GetNode<Godot.SpinBox>("PosY"));
                return _L_PosY;
            }
        }
        private PosY _L_PosY;

        public HBoxContainer2_1(MapEditorCreateMarkPanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override HBoxContainer2_1 Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.VBoxContainer"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.HBoxContainer2.VBoxContainer
    /// </summary>
    public class VBoxContainer_1 : UiNode<MapEditorCreateMarkPanel, Godot.VBoxContainer, VBoxContainer_1>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.HBoxContainer2.HBoxContainer
        /// </summary>
        public HBoxContainer L_HBoxContainer
        {
            get
            {
                if (_L_HBoxContainer == null) _L_HBoxContainer = new HBoxContainer(UiPanel, Instance.GetNode<Godot.HBoxContainer>("HBoxContainer"));
                return _L_HBoxContainer;
            }
        }
        private HBoxContainer _L_HBoxContainer;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.HBoxContainer2.HBoxContainer2
        /// </summary>
        public HBoxContainer2_1 L_HBoxContainer2
        {
            get
            {
                if (_L_HBoxContainer2 == null) _L_HBoxContainer2 = new HBoxContainer2_1(UiPanel, Instance.GetNode<Godot.HBoxContainer>("HBoxContainer2"));
                return _L_HBoxContainer2;
            }
        }
        private HBoxContainer2_1 _L_HBoxContainer2;

        public VBoxContainer_1(MapEditorCreateMarkPanel uiPanel, Godot.VBoxContainer node) : base(uiPanel, node) {  }
        public override VBoxContainer_1 Clone() => new (UiPanel, (Godot.VBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.HBoxContainer2
    /// </summary>
    public class HBoxContainer2 : UiNode<MapEditorCreateMarkPanel, Godot.HBoxContainer, HBoxContainer2>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.PosLabel
        /// </summary>
        public PosLabel L_PosLabel
        {
            get
            {
                if (_L_PosLabel == null) _L_PosLabel = new PosLabel(UiPanel, Instance.GetNode<Godot.Label>("PosLabel"));
                return _L_PosLabel;
            }
        }
        private PosLabel _L_PosLabel;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.VBoxContainer
        /// </summary>
        public VBoxContainer_1 L_VBoxContainer
        {
            get
            {
                if (_L_VBoxContainer == null) _L_VBoxContainer = new VBoxContainer_1(UiPanel, Instance.GetNode<Godot.VBoxContainer>("VBoxContainer"));
                return _L_VBoxContainer;
            }
        }
        private VBoxContainer_1 _L_VBoxContainer;

        public HBoxContainer2(MapEditorCreateMarkPanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override HBoxContainer2 Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.HBoxContainer3.SizeLabel
    /// </summary>
    public class SizeLabel : UiNode<MapEditorCreateMarkPanel, Godot.Label, SizeLabel>
    {
        public SizeLabel(MapEditorCreateMarkPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override SizeLabel Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.HBoxContainer3.VBoxContainer.HBoxContainer.Label
    /// </summary>
    public class Label_2 : UiNode<MapEditorCreateMarkPanel, Godot.Label, Label_2>
    {
        public Label_2(MapEditorCreateMarkPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override Label_2 Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.SpinBox"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.HBoxContainer3.VBoxContainer.HBoxContainer.SizeX
    /// </summary>
    public class SizeX : UiNode<MapEditorCreateMarkPanel, Godot.SpinBox, SizeX>
    {
        public SizeX(MapEditorCreateMarkPanel uiPanel, Godot.SpinBox node) : base(uiPanel, node) {  }
        public override SizeX Clone() => new (UiPanel, (Godot.SpinBox)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.HBoxContainer3.VBoxContainer.HBoxContainer
    /// </summary>
    public class HBoxContainer_1 : UiNode<MapEditorCreateMarkPanel, Godot.HBoxContainer, HBoxContainer_1>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.HBoxContainer3.VBoxContainer.Label
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
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.SpinBox"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.HBoxContainer3.VBoxContainer.SizeX
        /// </summary>
        public SizeX L_SizeX
        {
            get
            {
                if (_L_SizeX == null) _L_SizeX = new SizeX(UiPanel, Instance.GetNode<Godot.SpinBox>("SizeX"));
                return _L_SizeX;
            }
        }
        private SizeX _L_SizeX;

        public HBoxContainer_1(MapEditorCreateMarkPanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override HBoxContainer_1 Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.HBoxContainer3.VBoxContainer.HBoxContainer2.Label
    /// </summary>
    public class Label_3 : UiNode<MapEditorCreateMarkPanel, Godot.Label, Label_3>
    {
        public Label_3(MapEditorCreateMarkPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override Label_3 Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.SpinBox"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.HBoxContainer3.VBoxContainer.HBoxContainer2.SizeY
    /// </summary>
    public class SizeY : UiNode<MapEditorCreateMarkPanel, Godot.SpinBox, SizeY>
    {
        public SizeY(MapEditorCreateMarkPanel uiPanel, Godot.SpinBox node) : base(uiPanel, node) {  }
        public override SizeY Clone() => new (UiPanel, (Godot.SpinBox)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.HBoxContainer3.VBoxContainer.HBoxContainer2
    /// </summary>
    public class HBoxContainer2_2 : UiNode<MapEditorCreateMarkPanel, Godot.HBoxContainer, HBoxContainer2_2>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.HBoxContainer3.VBoxContainer.Label
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
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.SpinBox"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.HBoxContainer3.VBoxContainer.SizeY
        /// </summary>
        public SizeY L_SizeY
        {
            get
            {
                if (_L_SizeY == null) _L_SizeY = new SizeY(UiPanel, Instance.GetNode<Godot.SpinBox>("SizeY"));
                return _L_SizeY;
            }
        }
        private SizeY _L_SizeY;

        public HBoxContainer2_2(MapEditorCreateMarkPanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override HBoxContainer2_2 Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.VBoxContainer"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.HBoxContainer3.VBoxContainer
    /// </summary>
    public class VBoxContainer_2 : UiNode<MapEditorCreateMarkPanel, Godot.VBoxContainer, VBoxContainer_2>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.HBoxContainer3.HBoxContainer
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
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.HBoxContainer3.HBoxContainer2
        /// </summary>
        public HBoxContainer2_2 L_HBoxContainer2
        {
            get
            {
                if (_L_HBoxContainer2 == null) _L_HBoxContainer2 = new HBoxContainer2_2(UiPanel, Instance.GetNode<Godot.HBoxContainer>("HBoxContainer2"));
                return _L_HBoxContainer2;
            }
        }
        private HBoxContainer2_2 _L_HBoxContainer2;

        public VBoxContainer_2(MapEditorCreateMarkPanel uiPanel, Godot.VBoxContainer node) : base(uiPanel, node) {  }
        public override VBoxContainer_2 Clone() => new (UiPanel, (Godot.VBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.HBoxContainer3
    /// </summary>
    public class HBoxContainer3_1 : UiNode<MapEditorCreateMarkPanel, Godot.HBoxContainer, HBoxContainer3_1>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.SizeLabel
        /// </summary>
        public SizeLabel L_SizeLabel
        {
            get
            {
                if (_L_SizeLabel == null) _L_SizeLabel = new SizeLabel(UiPanel, Instance.GetNode<Godot.Label>("SizeLabel"));
                return _L_SizeLabel;
            }
        }
        private SizeLabel _L_SizeLabel;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.VBoxContainer
        /// </summary>
        public VBoxContainer_2 L_VBoxContainer
        {
            get
            {
                if (_L_VBoxContainer == null) _L_VBoxContainer = new VBoxContainer_2(UiPanel, Instance.GetNode<Godot.VBoxContainer>("VBoxContainer"));
                return _L_VBoxContainer;
            }
        }
        private VBoxContainer_2 _L_VBoxContainer;

        public HBoxContainer3_1(MapEditorCreateMarkPanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override HBoxContainer3_1 Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.DelayContainer.DelayNameLabel
    /// </summary>
    public class DelayNameLabel : UiNode<MapEditorCreateMarkPanel, Godot.Label, DelayNameLabel>
    {
        public DelayNameLabel(MapEditorCreateMarkPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override DelayNameLabel Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.SpinBox"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.DelayContainer.DelayInput
    /// </summary>
    public class DelayInput : UiNode<MapEditorCreateMarkPanel, Godot.SpinBox, DelayInput>
    {
        public DelayInput(MapEditorCreateMarkPanel uiPanel, Godot.SpinBox node) : base(uiPanel, node) {  }
        public override DelayInput Clone() => new (UiPanel, (Godot.SpinBox)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.DelayContainer
    /// </summary>
    public class DelayContainer : UiNode<MapEditorCreateMarkPanel, Godot.HBoxContainer, DelayContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.DelayNameLabel
        /// </summary>
        public DelayNameLabel L_DelayNameLabel
        {
            get
            {
                if (_L_DelayNameLabel == null) _L_DelayNameLabel = new DelayNameLabel(UiPanel, Instance.GetNode<Godot.Label>("DelayNameLabel"));
                return _L_DelayNameLabel;
            }
        }
        private DelayNameLabel _L_DelayNameLabel;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.SpinBox"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.DelayInput
        /// </summary>
        public DelayInput L_DelayInput
        {
            get
            {
                if (_L_DelayInput == null) _L_DelayInput = new DelayInput(UiPanel, Instance.GetNode<Godot.SpinBox>("DelayInput"));
                return _L_DelayInput;
            }
        }
        private DelayInput _L_DelayInput;

        public DelayContainer(MapEditorCreateMarkPanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override DelayContainer Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3
    /// </summary>
    public class HBoxContainer3 : UiNode<MapEditorCreateMarkPanel, Godot.HBoxContainer, HBoxContainer3>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer2
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
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3
        /// </summary>
        public HBoxContainer3_1 L_HBoxContainer3
        {
            get
            {
                if (_L_HBoxContainer3 == null) _L_HBoxContainer3 = new HBoxContainer3_1(UiPanel, Instance.GetNode<Godot.HBoxContainer>("HBoxContainer3"));
                return _L_HBoxContainer3;
            }
        }
        private HBoxContainer3_1 _L_HBoxContainer3;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.DelayContainer
        /// </summary>
        public DelayContainer L_DelayContainer
        {
            get
            {
                if (_L_DelayContainer == null) _L_DelayContainer = new DelayContainer(UiPanel, Instance.GetNode<Godot.HBoxContainer>("DelayContainer"));
                return _L_DelayContainer;
            }
        }
        private DelayContainer _L_DelayContainer;

        public HBoxContainer3(MapEditorCreateMarkPanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override HBoxContainer3 Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Button"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.AddMark
    /// </summary>
    public class AddMark : UiNode<MapEditorCreateMarkPanel, Godot.Button, AddMark>
    {
        public AddMark(MapEditorCreateMarkPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override AddMark Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Control"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.HBoxContainer.Control
    /// </summary>
    public class Control : UiNode<MapEditorCreateMarkPanel, Godot.Control, Control>
    {
        public Control(MapEditorCreateMarkPanel uiPanel, Godot.Control node) : base(uiPanel, node) {  }
        public override Control Clone() => new (UiPanel, (Godot.Control)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.HBoxContainer.IconTitle
    /// </summary>
    public class IconTitle : UiNode<MapEditorCreateMarkPanel, Godot.Label, IconTitle>
    {
        public IconTitle(MapEditorCreateMarkPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override IconTitle Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.HBoxContainer.IdTitle
    /// </summary>
    public class IdTitle : UiNode<MapEditorCreateMarkPanel, Godot.Label, IdTitle>
    {
        public IdTitle(MapEditorCreateMarkPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override IdTitle Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.HBoxContainer.NameTitle
    /// </summary>
    public class NameTitle : UiNode<MapEditorCreateMarkPanel, Godot.Label, NameTitle>
    {
        public NameTitle(MapEditorCreateMarkPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override NameTitle Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.HBoxContainer.TypeTitle
    /// </summary>
    public class TypeTitle : UiNode<MapEditorCreateMarkPanel, Godot.Label, TypeTitle>
    {
        public TypeTitle(MapEditorCreateMarkPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override TypeTitle Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.HBoxContainer.WeightTitle
    /// </summary>
    public class WeightTitle : UiNode<MapEditorCreateMarkPanel, Godot.Label, WeightTitle>
    {
        public WeightTitle(MapEditorCreateMarkPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override WeightTitle Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.HBoxContainer.ExtraTitle
    /// </summary>
    public class ExtraTitle : UiNode<MapEditorCreateMarkPanel, Godot.Label, ExtraTitle>
    {
        public ExtraTitle(MapEditorCreateMarkPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override ExtraTitle Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.HBoxContainer
    /// </summary>
    public class HBoxContainer_2 : UiNode<MapEditorCreateMarkPanel, Godot.HBoxContainer, HBoxContainer_2>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Control"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.Control
        /// </summary>
        public Control L_Control
        {
            get
            {
                if (_L_Control == null) _L_Control = new Control(UiPanel, Instance.GetNode<Godot.Control>("Control"));
                return _L_Control;
            }
        }
        private Control _L_Control;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.IconTitle
        /// </summary>
        public IconTitle L_IconTitle
        {
            get
            {
                if (_L_IconTitle == null) _L_IconTitle = new IconTitle(UiPanel, Instance.GetNode<Godot.Label>("IconTitle"));
                return _L_IconTitle;
            }
        }
        private IconTitle _L_IconTitle;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.IdTitle
        /// </summary>
        public IdTitle L_IdTitle
        {
            get
            {
                if (_L_IdTitle == null) _L_IdTitle = new IdTitle(UiPanel, Instance.GetNode<Godot.Label>("IdTitle"));
                return _L_IdTitle;
            }
        }
        private IdTitle _L_IdTitle;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.NameTitle
        /// </summary>
        public NameTitle L_NameTitle
        {
            get
            {
                if (_L_NameTitle == null) _L_NameTitle = new NameTitle(UiPanel, Instance.GetNode<Godot.Label>("NameTitle"));
                return _L_NameTitle;
            }
        }
        private NameTitle _L_NameTitle;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.TypeTitle
        /// </summary>
        public TypeTitle L_TypeTitle
        {
            get
            {
                if (_L_TypeTitle == null) _L_TypeTitle = new TypeTitle(UiPanel, Instance.GetNode<Godot.Label>("TypeTitle"));
                return _L_TypeTitle;
            }
        }
        private TypeTitle _L_TypeTitle;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.WeightTitle
        /// </summary>
        public WeightTitle L_WeightTitle
        {
            get
            {
                if (_L_WeightTitle == null) _L_WeightTitle = new WeightTitle(UiPanel, Instance.GetNode<Godot.Label>("WeightTitle"));
                return _L_WeightTitle;
            }
        }
        private WeightTitle _L_WeightTitle;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.ExtraTitle
        /// </summary>
        public ExtraTitle L_ExtraTitle
        {
            get
            {
                if (_L_ExtraTitle == null) _L_ExtraTitle = new ExtraTitle(UiPanel, Instance.GetNode<Godot.Label>("ExtraTitle"));
                return _L_ExtraTitle;
            }
        }
        private ExtraTitle _L_ExtraTitle;

        public HBoxContainer_2(MapEditorCreateMarkPanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override HBoxContainer_2 Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Button"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.ScrollContainer.MarkObject.VBoxContainer.HBoxContainer.ExpandButton
    /// </summary>
    public class ExpandButton : UiNode<MapEditorCreateMarkPanel, Godot.Button, ExpandButton>
    {
        public ExpandButton(MapEditorCreateMarkPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override ExpandButton Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.TextureRect"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.ScrollContainer.MarkObject.VBoxContainer.HBoxContainer.Icon
    /// </summary>
    public class Icon : UiNode<MapEditorCreateMarkPanel, Godot.TextureRect, Icon>
    {
        public Icon(MapEditorCreateMarkPanel uiPanel, Godot.TextureRect node) : base(uiPanel, node) {  }
        public override Icon Clone() => new (UiPanel, (Godot.TextureRect)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.ScrollContainer.MarkObject.VBoxContainer.HBoxContainer.IdLabel
    /// </summary>
    public class IdLabel : UiNode<MapEditorCreateMarkPanel, Godot.Label, IdLabel>
    {
        public IdLabel(MapEditorCreateMarkPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override IdLabel Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.ScrollContainer.MarkObject.VBoxContainer.HBoxContainer.NameLabel
    /// </summary>
    public class NameLabel : UiNode<MapEditorCreateMarkPanel, Godot.Label, NameLabel>
    {
        public NameLabel(MapEditorCreateMarkPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override NameLabel Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.ScrollContainer.MarkObject.VBoxContainer.HBoxContainer.TypeLabel
    /// </summary>
    public class TypeLabel : UiNode<MapEditorCreateMarkPanel, Godot.Label, TypeLabel>
    {
        public TypeLabel(MapEditorCreateMarkPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override TypeLabel Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.SpinBox"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.ScrollContainer.MarkObject.VBoxContainer.HBoxContainer.WeightEdit
    /// </summary>
    public class WeightEdit : UiNode<MapEditorCreateMarkPanel, Godot.SpinBox, WeightEdit>
    {
        public WeightEdit(MapEditorCreateMarkPanel uiPanel, Godot.SpinBox node) : base(uiPanel, node) {  }
        public override WeightEdit Clone() => new (UiPanel, (Godot.SpinBox)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Button"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.ScrollContainer.MarkObject.VBoxContainer.HBoxContainer.CenterContainer.DeleteButton
    /// </summary>
    public class DeleteButton : UiNode<MapEditorCreateMarkPanel, Godot.Button, DeleteButton>
    {
        public DeleteButton(MapEditorCreateMarkPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override DeleteButton Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.CenterContainer"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.ScrollContainer.MarkObject.VBoxContainer.HBoxContainer.CenterContainer
    /// </summary>
    public class CenterContainer : UiNode<MapEditorCreateMarkPanel, Godot.CenterContainer, CenterContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Button"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.ScrollContainer.MarkObject.VBoxContainer.HBoxContainer.DeleteButton
        /// </summary>
        public DeleteButton L_DeleteButton
        {
            get
            {
                if (_L_DeleteButton == null) _L_DeleteButton = new DeleteButton(UiPanel, Instance.GetNode<Godot.Button>("DeleteButton"));
                return _L_DeleteButton;
            }
        }
        private DeleteButton _L_DeleteButton;

        public CenterContainer(MapEditorCreateMarkPanel uiPanel, Godot.CenterContainer node) : base(uiPanel, node) {  }
        public override CenterContainer Clone() => new (UiPanel, (Godot.CenterContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.ScrollContainer.MarkObject.VBoxContainer.HBoxContainer
    /// </summary>
    public class HBoxContainer_3 : UiNode<MapEditorCreateMarkPanel, Godot.HBoxContainer, HBoxContainer_3>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Button"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.ScrollContainer.MarkObject.VBoxContainer.ExpandButton
        /// </summary>
        public ExpandButton L_ExpandButton
        {
            get
            {
                if (_L_ExpandButton == null) _L_ExpandButton = new ExpandButton(UiPanel, Instance.GetNode<Godot.Button>("ExpandButton"));
                return _L_ExpandButton;
            }
        }
        private ExpandButton _L_ExpandButton;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.TextureRect"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.ScrollContainer.MarkObject.VBoxContainer.Icon
        /// </summary>
        public Icon L_Icon
        {
            get
            {
                if (_L_Icon == null) _L_Icon = new Icon(UiPanel, Instance.GetNode<Godot.TextureRect>("Icon"));
                return _L_Icon;
            }
        }
        private Icon _L_Icon;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.ScrollContainer.MarkObject.VBoxContainer.IdLabel
        /// </summary>
        public IdLabel L_IdLabel
        {
            get
            {
                if (_L_IdLabel == null) _L_IdLabel = new IdLabel(UiPanel, Instance.GetNode<Godot.Label>("IdLabel"));
                return _L_IdLabel;
            }
        }
        private IdLabel _L_IdLabel;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.ScrollContainer.MarkObject.VBoxContainer.NameLabel
        /// </summary>
        public NameLabel L_NameLabel
        {
            get
            {
                if (_L_NameLabel == null) _L_NameLabel = new NameLabel(UiPanel, Instance.GetNode<Godot.Label>("NameLabel"));
                return _L_NameLabel;
            }
        }
        private NameLabel _L_NameLabel;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.ScrollContainer.MarkObject.VBoxContainer.TypeLabel
        /// </summary>
        public TypeLabel L_TypeLabel
        {
            get
            {
                if (_L_TypeLabel == null) _L_TypeLabel = new TypeLabel(UiPanel, Instance.GetNode<Godot.Label>("TypeLabel"));
                return _L_TypeLabel;
            }
        }
        private TypeLabel _L_TypeLabel;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.SpinBox"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.ScrollContainer.MarkObject.VBoxContainer.WeightEdit
        /// </summary>
        public WeightEdit L_WeightEdit
        {
            get
            {
                if (_L_WeightEdit == null) _L_WeightEdit = new WeightEdit(UiPanel, Instance.GetNode<Godot.SpinBox>("WeightEdit"));
                return _L_WeightEdit;
            }
        }
        private WeightEdit _L_WeightEdit;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.CenterContainer"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.ScrollContainer.MarkObject.VBoxContainer.CenterContainer
        /// </summary>
        public CenterContainer L_CenterContainer
        {
            get
            {
                if (_L_CenterContainer == null) _L_CenterContainer = new CenterContainer(UiPanel, Instance.GetNode<Godot.CenterContainer>("CenterContainer"));
                return _L_CenterContainer;
            }
        }
        private CenterContainer _L_CenterContainer;

        public HBoxContainer_3(MapEditorCreateMarkPanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override HBoxContainer_3 Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.VBoxContainer"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.ScrollContainer.MarkObject.VBoxContainer
    /// </summary>
    public class VBoxContainer_4 : UiNode<MapEditorCreateMarkPanel, Godot.VBoxContainer, VBoxContainer_4>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.ScrollContainer.MarkObject.HBoxContainer
        /// </summary>
        public HBoxContainer_3 L_HBoxContainer
        {
            get
            {
                if (_L_HBoxContainer == null) _L_HBoxContainer = new HBoxContainer_3(UiPanel, Instance.GetNode<Godot.HBoxContainer>("HBoxContainer"));
                return _L_HBoxContainer;
            }
        }
        private HBoxContainer_3 _L_HBoxContainer;

        public VBoxContainer_4(MapEditorCreateMarkPanel uiPanel, Godot.VBoxContainer node) : base(uiPanel, node) {  }
        public override VBoxContainer_4 Clone() => new (UiPanel, (Godot.VBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.PanelContainer"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.ScrollContainer.MarkObject
    /// </summary>
    public class MarkObject : UiNode<MapEditorCreateMarkPanel, Godot.PanelContainer, MarkObject>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.ScrollContainer.VBoxContainer
        /// </summary>
        public VBoxContainer_4 L_VBoxContainer
        {
            get
            {
                if (_L_VBoxContainer == null) _L_VBoxContainer = new VBoxContainer_4(UiPanel, Instance.GetNode<Godot.VBoxContainer>("VBoxContainer"));
                return _L_VBoxContainer;
            }
        }
        private VBoxContainer_4 _L_VBoxContainer;

        public MarkObject(MapEditorCreateMarkPanel uiPanel, Godot.PanelContainer node) : base(uiPanel, node) {  }
        public override MarkObject Clone() => new (UiPanel, (Godot.PanelContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.ScrollContainer"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.ScrollContainer
    /// </summary>
    public class ScrollContainer : UiNode<MapEditorCreateMarkPanel, Godot.ScrollContainer, ScrollContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.PanelContainer"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.MarkObject
        /// </summary>
        public MarkObject L_MarkObject
        {
            get
            {
                if (_L_MarkObject == null) _L_MarkObject = new MarkObject(UiPanel, Instance.GetNode<Godot.PanelContainer>("MarkObject"));
                return _L_MarkObject;
            }
        }
        private MarkObject _L_MarkObject;

        public ScrollContainer(MapEditorCreateMarkPanel uiPanel, Godot.ScrollContainer node) : base(uiPanel, node) {  }
        public override ScrollContainer Clone() => new (UiPanel, (Godot.ScrollContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.VBoxContainer"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer
    /// </summary>
    public class VBoxContainer_3 : UiNode<MapEditorCreateMarkPanel, Godot.VBoxContainer, VBoxContainer_3>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.HBoxContainer
        /// </summary>
        public HBoxContainer_2 L_HBoxContainer
        {
            get
            {
                if (_L_HBoxContainer == null) _L_HBoxContainer = new HBoxContainer_2(UiPanel, Instance.GetNode<Godot.HBoxContainer>("HBoxContainer"));
                return _L_HBoxContainer;
            }
        }
        private HBoxContainer_2 _L_HBoxContainer;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.ScrollContainer"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.ScrollContainer
        /// </summary>
        public ScrollContainer L_ScrollContainer
        {
            get
            {
                if (_L_ScrollContainer == null) _L_ScrollContainer = new ScrollContainer(UiPanel, Instance.GetNode<Godot.ScrollContainer>("ScrollContainer"));
                return _L_ScrollContainer;
            }
        }
        private ScrollContainer _L_ScrollContainer;

        public VBoxContainer_3(MapEditorCreateMarkPanel uiPanel, Godot.VBoxContainer node) : base(uiPanel, node) {  }
        public override VBoxContainer_3 Clone() => new (UiPanel, (Godot.VBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.MarginContainer"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer
    /// </summary>
    public class MarginContainer_1 : UiNode<MapEditorCreateMarkPanel, Godot.MarginContainer, MarginContainer_1>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.VBoxContainer
        /// </summary>
        public VBoxContainer_3 L_VBoxContainer
        {
            get
            {
                if (_L_VBoxContainer == null) _L_VBoxContainer = new VBoxContainer_3(UiPanel, Instance.GetNode<Godot.VBoxContainer>("VBoxContainer"));
                return _L_VBoxContainer;
            }
        }
        private VBoxContainer_3 _L_VBoxContainer;

        public MarginContainer_1(MapEditorCreateMarkPanel uiPanel, Godot.MarginContainer node) : base(uiPanel, node) {  }
        public override MarginContainer_1 Clone() => new (UiPanel, (Godot.MarginContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Panel"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel
    /// </summary>
    public class Panel : UiNode<MapEditorCreateMarkPanel, Godot.Panel, Panel>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.MarginContainer"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.MarginContainer
        /// </summary>
        public MarginContainer_1 L_MarginContainer
        {
            get
            {
                if (_L_MarginContainer == null) _L_MarginContainer = new MarginContainer_1(UiPanel, Instance.GetNode<Godot.MarginContainer>("MarginContainer"));
                return _L_MarginContainer;
            }
        }
        private MarginContainer_1 _L_MarginContainer;

        public Panel(MapEditorCreateMarkPanel uiPanel, Godot.Panel node) : base(uiPanel, node) {  }
        public override Panel Clone() => new (UiPanel, (Godot.Panel)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.VBoxContainer"/>, 路径: MapEditorCreateMark.MarginContainer.VBoxContainer
    /// </summary>
    public class VBoxContainer : UiNode<MapEditorCreateMarkPanel, Godot.VBoxContainer, VBoxContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: MapEditorCreateMark.MarginContainer.HBoxContainer3
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
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Button"/>, 节点路径: MapEditorCreateMark.MarginContainer.AddMark
        /// </summary>
        public AddMark L_AddMark
        {
            get
            {
                if (_L_AddMark == null) _L_AddMark = new AddMark(UiPanel, Instance.GetNode<Godot.Button>("AddMark"));
                return _L_AddMark;
            }
        }
        private AddMark _L_AddMark;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Panel"/>, 节点路径: MapEditorCreateMark.MarginContainer.Panel
        /// </summary>
        public Panel L_Panel
        {
            get
            {
                if (_L_Panel == null) _L_Panel = new Panel(UiPanel, Instance.GetNode<Godot.Panel>("Panel"));
                return _L_Panel;
            }
        }
        private Panel _L_Panel;

        public VBoxContainer(MapEditorCreateMarkPanel uiPanel, Godot.VBoxContainer node) : base(uiPanel, node) {  }
        public override VBoxContainer Clone() => new (UiPanel, (Godot.VBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.MarginContainer"/>, 路径: MapEditorCreateMark.MarginContainer
    /// </summary>
    public class MarginContainer : UiNode<MapEditorCreateMarkPanel, Godot.MarginContainer, MarginContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: MapEditorCreateMark.VBoxContainer
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

        public MarginContainer(MapEditorCreateMarkPanel uiPanel, Godot.MarginContainer node) : base(uiPanel, node) {  }
        public override MarginContainer Clone() => new (UiPanel, (Godot.MarginContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.GridContainer"/>, 路径: MapEditorCreateMark.ExpandPanel.ExpandGrid
    /// </summary>
    public class ExpandGrid : UiNode<MapEditorCreateMarkPanel, Godot.GridContainer, ExpandGrid>
    {
        public ExpandGrid(MapEditorCreateMarkPanel uiPanel, Godot.GridContainer node) : base(uiPanel, node) {  }
        public override ExpandGrid Clone() => new (UiPanel, (Godot.GridContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.MarginContainer"/>, 路径: MapEditorCreateMark.ExpandPanel
    /// </summary>
    public class ExpandPanel : UiNode<MapEditorCreateMarkPanel, Godot.MarginContainer, ExpandPanel>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.GridContainer"/>, 节点路径: MapEditorCreateMark.ExpandGrid
        /// </summary>
        public ExpandGrid L_ExpandGrid
        {
            get
            {
                if (_L_ExpandGrid == null) _L_ExpandGrid = new ExpandGrid(UiPanel, Instance.GetNode<Godot.GridContainer>("ExpandGrid"));
                return _L_ExpandGrid;
            }
        }
        private ExpandGrid _L_ExpandGrid;

        public ExpandPanel(MapEditorCreateMarkPanel uiPanel, Godot.MarginContainer node) : base(uiPanel, node) {  }
        public override ExpandPanel Clone() => new (UiPanel, (Godot.MarginContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: MapEditorCreateMark.NumberBar.AttrName
    /// </summary>
    public class AttrName : UiNode<MapEditorCreateMarkPanel, Godot.Label, AttrName>
    {
        public AttrName(MapEditorCreateMarkPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override AttrName Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.SpinBox"/>, 路径: MapEditorCreateMark.NumberBar.NumInput
    /// </summary>
    public class NumInput : UiNode<MapEditorCreateMarkPanel, Godot.SpinBox, NumInput>
    {
        public NumInput(MapEditorCreateMarkPanel uiPanel, Godot.SpinBox node) : base(uiPanel, node) {  }
        public override NumInput Clone() => new (UiPanel, (Godot.SpinBox)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="UI.MapEditorCreateMark.NumberAttribute"/>, 路径: MapEditorCreateMark.NumberBar
    /// </summary>
    public class NumberBar : UiNode<MapEditorCreateMarkPanel, UI.MapEditorCreateMark.NumberAttribute, NumberBar>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: MapEditorCreateMark.AttrName
        /// </summary>
        public AttrName L_AttrName
        {
            get
            {
                if (_L_AttrName == null) _L_AttrName = new AttrName(UiPanel, Instance.GetNode<Godot.Label>("AttrName"));
                return _L_AttrName;
            }
        }
        private AttrName _L_AttrName;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.SpinBox"/>, 节点路径: MapEditorCreateMark.NumInput
        /// </summary>
        public NumInput L_NumInput
        {
            get
            {
                if (_L_NumInput == null) _L_NumInput = new NumInput(UiPanel, Instance.GetNode<Godot.SpinBox>("NumInput"));
                return _L_NumInput;
            }
        }
        private NumInput _L_NumInput;

        public NumberBar(MapEditorCreateMarkPanel uiPanel, UI.MapEditorCreateMark.NumberAttribute node) : base(uiPanel, node) {  }
        public override NumberBar Clone() => new (UiPanel, (UI.MapEditorCreateMark.NumberAttribute)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: MapEditorCreateMark.OptionBar.AttrName
    /// </summary>
    public class AttrName_1 : UiNode<MapEditorCreateMarkPanel, Godot.Label, AttrName_1>
    {
        public AttrName_1(MapEditorCreateMarkPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override AttrName_1 Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.OptionButton"/>, 路径: MapEditorCreateMark.OptionBar.OptionInput
    /// </summary>
    public class OptionInput : UiNode<MapEditorCreateMarkPanel, Godot.OptionButton, OptionInput>
    {
        public OptionInput(MapEditorCreateMarkPanel uiPanel, Godot.OptionButton node) : base(uiPanel, node) {  }
        public override OptionInput Clone() => new (UiPanel, (Godot.OptionButton)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="UI.MapEditorCreateMark.OptionAttribute"/>, 路径: MapEditorCreateMark.OptionBar
    /// </summary>
    public class OptionBar : UiNode<MapEditorCreateMarkPanel, UI.MapEditorCreateMark.OptionAttribute, OptionBar>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: MapEditorCreateMark.AttrName
        /// </summary>
        public AttrName_1 L_AttrName
        {
            get
            {
                if (_L_AttrName == null) _L_AttrName = new AttrName_1(UiPanel, Instance.GetNode<Godot.Label>("AttrName"));
                return _L_AttrName;
            }
        }
        private AttrName_1 _L_AttrName;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.OptionButton"/>, 节点路径: MapEditorCreateMark.OptionInput
        /// </summary>
        public OptionInput L_OptionInput
        {
            get
            {
                if (_L_OptionInput == null) _L_OptionInput = new OptionInput(UiPanel, Instance.GetNode<Godot.OptionButton>("OptionInput"));
                return _L_OptionInput;
            }
        }
        private OptionInput _L_OptionInput;

        public OptionBar(MapEditorCreateMarkPanel uiPanel, UI.MapEditorCreateMark.OptionAttribute node) : base(uiPanel, node) {  }
        public override OptionBar Clone() => new (UiPanel, (UI.MapEditorCreateMark.OptionAttribute)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: MapEditorCreateMark.ObjectBar.AttrName
    /// </summary>
    public class AttrName_2 : UiNode<MapEditorCreateMarkPanel, Godot.Label, AttrName_2>
    {
        public AttrName_2(MapEditorCreateMarkPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override AttrName_2 Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Button"/>, 路径: MapEditorCreateMark.ObjectBar.HBoxContainer.SelectButton
    /// </summary>
    public class SelectButton : UiNode<MapEditorCreateMarkPanel, Godot.Button, SelectButton>
    {
        public SelectButton(MapEditorCreateMarkPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override SelectButton Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.TextureRect"/>, 路径: MapEditorCreateMark.ObjectBar.HBoxContainer.ObjectIcon
    /// </summary>
    public class ObjectIcon : UiNode<MapEditorCreateMarkPanel, Godot.TextureRect, ObjectIcon>
    {
        public ObjectIcon(MapEditorCreateMarkPanel uiPanel, Godot.TextureRect node) : base(uiPanel, node) {  }
        public override ObjectIcon Clone() => new (UiPanel, (Godot.TextureRect)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: MapEditorCreateMark.ObjectBar.HBoxContainer.ObjectName
    /// </summary>
    public class ObjectName : UiNode<MapEditorCreateMarkPanel, Godot.Label, ObjectName>
    {
        public ObjectName(MapEditorCreateMarkPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override ObjectName Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Button"/>, 路径: MapEditorCreateMark.ObjectBar.HBoxContainer.DeleteButton
    /// </summary>
    public class DeleteButton_1 : UiNode<MapEditorCreateMarkPanel, Godot.Button, DeleteButton_1>
    {
        public DeleteButton_1(MapEditorCreateMarkPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override DeleteButton_1 Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: MapEditorCreateMark.ObjectBar.HBoxContainer
    /// </summary>
    public class HBoxContainer_4 : UiNode<MapEditorCreateMarkPanel, Godot.HBoxContainer, HBoxContainer_4>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Button"/>, 节点路径: MapEditorCreateMark.ObjectBar.SelectButton
        /// </summary>
        public SelectButton L_SelectButton
        {
            get
            {
                if (_L_SelectButton == null) _L_SelectButton = new SelectButton(UiPanel, Instance.GetNode<Godot.Button>("SelectButton"));
                return _L_SelectButton;
            }
        }
        private SelectButton _L_SelectButton;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.TextureRect"/>, 节点路径: MapEditorCreateMark.ObjectBar.ObjectIcon
        /// </summary>
        public ObjectIcon L_ObjectIcon
        {
            get
            {
                if (_L_ObjectIcon == null) _L_ObjectIcon = new ObjectIcon(UiPanel, Instance.GetNode<Godot.TextureRect>("ObjectIcon"));
                return _L_ObjectIcon;
            }
        }
        private ObjectIcon _L_ObjectIcon;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: MapEditorCreateMark.ObjectBar.ObjectName
        /// </summary>
        public ObjectName L_ObjectName
        {
            get
            {
                if (_L_ObjectName == null) _L_ObjectName = new ObjectName(UiPanel, Instance.GetNode<Godot.Label>("ObjectName"));
                return _L_ObjectName;
            }
        }
        private ObjectName _L_ObjectName;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Button"/>, 节点路径: MapEditorCreateMark.ObjectBar.DeleteButton
        /// </summary>
        public DeleteButton_1 L_DeleteButton
        {
            get
            {
                if (_L_DeleteButton == null) _L_DeleteButton = new DeleteButton_1(UiPanel, Instance.GetNode<Godot.Button>("DeleteButton"));
                return _L_DeleteButton;
            }
        }
        private DeleteButton_1 _L_DeleteButton;

        public HBoxContainer_4(MapEditorCreateMarkPanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override HBoxContainer_4 Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="UI.MapEditorCreateMark.ObjectAttribute"/>, 路径: MapEditorCreateMark.ObjectBar
    /// </summary>
    public class ObjectBar : UiNode<MapEditorCreateMarkPanel, UI.MapEditorCreateMark.ObjectAttribute, ObjectBar>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: MapEditorCreateMark.AttrName
        /// </summary>
        public AttrName_2 L_AttrName
        {
            get
            {
                if (_L_AttrName == null) _L_AttrName = new AttrName_2(UiPanel, Instance.GetNode<Godot.Label>("AttrName"));
                return _L_AttrName;
            }
        }
        private AttrName_2 _L_AttrName;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: MapEditorCreateMark.HBoxContainer
        /// </summary>
        public HBoxContainer_4 L_HBoxContainer
        {
            get
            {
                if (_L_HBoxContainer == null) _L_HBoxContainer = new HBoxContainer_4(UiPanel, Instance.GetNode<Godot.HBoxContainer>("HBoxContainer"));
                return _L_HBoxContainer;
            }
        }
        private HBoxContainer_4 _L_HBoxContainer;

        public ObjectBar(MapEditorCreateMarkPanel uiPanel, UI.MapEditorCreateMark.ObjectAttribute node) : base(uiPanel, node) {  }
        public override ObjectBar Clone() => new (UiPanel, (UI.MapEditorCreateMark.ObjectAttribute)Instance.Duplicate());
    }


    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Label"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.HBoxContainer2.PosLabel
    /// </summary>
    public PosLabel S_PosLabel => L_MarginContainer.L_VBoxContainer.L_HBoxContainer3.L_HBoxContainer2.L_PosLabel;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.SpinBox"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.HBoxContainer2.VBoxContainer.HBoxContainer.PosX
    /// </summary>
    public PosX S_PosX => L_MarginContainer.L_VBoxContainer.L_HBoxContainer3.L_HBoxContainer2.L_VBoxContainer.L_HBoxContainer.L_PosX;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.SpinBox"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.HBoxContainer2.VBoxContainer.HBoxContainer2.PosY
    /// </summary>
    public PosY S_PosY => L_MarginContainer.L_VBoxContainer.L_HBoxContainer3.L_HBoxContainer2.L_VBoxContainer.L_HBoxContainer2.L_PosY;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Label"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.HBoxContainer3.SizeLabel
    /// </summary>
    public SizeLabel S_SizeLabel => L_MarginContainer.L_VBoxContainer.L_HBoxContainer3.L_HBoxContainer3.L_SizeLabel;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.SpinBox"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.HBoxContainer3.VBoxContainer.HBoxContainer.SizeX
    /// </summary>
    public SizeX S_SizeX => L_MarginContainer.L_VBoxContainer.L_HBoxContainer3.L_HBoxContainer3.L_VBoxContainer.L_HBoxContainer.L_SizeX;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.SpinBox"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.HBoxContainer3.VBoxContainer.HBoxContainer2.SizeY
    /// </summary>
    public SizeY S_SizeY => L_MarginContainer.L_VBoxContainer.L_HBoxContainer3.L_HBoxContainer3.L_VBoxContainer.L_HBoxContainer2.L_SizeY;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Label"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.DelayContainer.DelayNameLabel
    /// </summary>
    public DelayNameLabel S_DelayNameLabel => L_MarginContainer.L_VBoxContainer.L_HBoxContainer3.L_DelayContainer.L_DelayNameLabel;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.SpinBox"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.DelayContainer.DelayInput
    /// </summary>
    public DelayInput S_DelayInput => L_MarginContainer.L_VBoxContainer.L_HBoxContainer3.L_DelayContainer.L_DelayInput;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.HBoxContainer3.DelayContainer
    /// </summary>
    public DelayContainer S_DelayContainer => L_MarginContainer.L_VBoxContainer.L_HBoxContainer3.L_DelayContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Button"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.AddMark
    /// </summary>
    public AddMark S_AddMark => L_MarginContainer.L_VBoxContainer.L_AddMark;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Control"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.HBoxContainer.Control
    /// </summary>
    public Control S_Control => L_MarginContainer.L_VBoxContainer.L_Panel.L_MarginContainer.L_VBoxContainer.L_HBoxContainer.L_Control;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Label"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.HBoxContainer.IconTitle
    /// </summary>
    public IconTitle S_IconTitle => L_MarginContainer.L_VBoxContainer.L_Panel.L_MarginContainer.L_VBoxContainer.L_HBoxContainer.L_IconTitle;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Label"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.HBoxContainer.IdTitle
    /// </summary>
    public IdTitle S_IdTitle => L_MarginContainer.L_VBoxContainer.L_Panel.L_MarginContainer.L_VBoxContainer.L_HBoxContainer.L_IdTitle;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Label"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.HBoxContainer.NameTitle
    /// </summary>
    public NameTitle S_NameTitle => L_MarginContainer.L_VBoxContainer.L_Panel.L_MarginContainer.L_VBoxContainer.L_HBoxContainer.L_NameTitle;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Label"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.HBoxContainer.TypeTitle
    /// </summary>
    public TypeTitle S_TypeTitle => L_MarginContainer.L_VBoxContainer.L_Panel.L_MarginContainer.L_VBoxContainer.L_HBoxContainer.L_TypeTitle;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Label"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.HBoxContainer.WeightTitle
    /// </summary>
    public WeightTitle S_WeightTitle => L_MarginContainer.L_VBoxContainer.L_Panel.L_MarginContainer.L_VBoxContainer.L_HBoxContainer.L_WeightTitle;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Label"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.HBoxContainer.ExtraTitle
    /// </summary>
    public ExtraTitle S_ExtraTitle => L_MarginContainer.L_VBoxContainer.L_Panel.L_MarginContainer.L_VBoxContainer.L_HBoxContainer.L_ExtraTitle;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Button"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.ScrollContainer.MarkObject.VBoxContainer.HBoxContainer.ExpandButton
    /// </summary>
    public ExpandButton S_ExpandButton => L_MarginContainer.L_VBoxContainer.L_Panel.L_MarginContainer.L_VBoxContainer.L_ScrollContainer.L_MarkObject.L_VBoxContainer.L_HBoxContainer.L_ExpandButton;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.TextureRect"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.ScrollContainer.MarkObject.VBoxContainer.HBoxContainer.Icon
    /// </summary>
    public Icon S_Icon => L_MarginContainer.L_VBoxContainer.L_Panel.L_MarginContainer.L_VBoxContainer.L_ScrollContainer.L_MarkObject.L_VBoxContainer.L_HBoxContainer.L_Icon;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Label"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.ScrollContainer.MarkObject.VBoxContainer.HBoxContainer.IdLabel
    /// </summary>
    public IdLabel S_IdLabel => L_MarginContainer.L_VBoxContainer.L_Panel.L_MarginContainer.L_VBoxContainer.L_ScrollContainer.L_MarkObject.L_VBoxContainer.L_HBoxContainer.L_IdLabel;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Label"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.ScrollContainer.MarkObject.VBoxContainer.HBoxContainer.NameLabel
    /// </summary>
    public NameLabel S_NameLabel => L_MarginContainer.L_VBoxContainer.L_Panel.L_MarginContainer.L_VBoxContainer.L_ScrollContainer.L_MarkObject.L_VBoxContainer.L_HBoxContainer.L_NameLabel;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Label"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.ScrollContainer.MarkObject.VBoxContainer.HBoxContainer.TypeLabel
    /// </summary>
    public TypeLabel S_TypeLabel => L_MarginContainer.L_VBoxContainer.L_Panel.L_MarginContainer.L_VBoxContainer.L_ScrollContainer.L_MarkObject.L_VBoxContainer.L_HBoxContainer.L_TypeLabel;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.SpinBox"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.ScrollContainer.MarkObject.VBoxContainer.HBoxContainer.WeightEdit
    /// </summary>
    public WeightEdit S_WeightEdit => L_MarginContainer.L_VBoxContainer.L_Panel.L_MarginContainer.L_VBoxContainer.L_ScrollContainer.L_MarkObject.L_VBoxContainer.L_HBoxContainer.L_WeightEdit;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.CenterContainer"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.ScrollContainer.MarkObject.VBoxContainer.HBoxContainer.CenterContainer
    /// </summary>
    public CenterContainer S_CenterContainer => L_MarginContainer.L_VBoxContainer.L_Panel.L_MarginContainer.L_VBoxContainer.L_ScrollContainer.L_MarkObject.L_VBoxContainer.L_HBoxContainer.L_CenterContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.PanelContainer"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.ScrollContainer.MarkObject
    /// </summary>
    public MarkObject S_MarkObject => L_MarginContainer.L_VBoxContainer.L_Panel.L_MarginContainer.L_VBoxContainer.L_ScrollContainer.L_MarkObject;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.ScrollContainer"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel.MarginContainer.VBoxContainer.ScrollContainer
    /// </summary>
    public ScrollContainer S_ScrollContainer => L_MarginContainer.L_VBoxContainer.L_Panel.L_MarginContainer.L_VBoxContainer.L_ScrollContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Panel"/>, 节点路径: MapEditorCreateMark.MarginContainer.VBoxContainer.Panel
    /// </summary>
    public Panel S_Panel => L_MarginContainer.L_VBoxContainer.L_Panel;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.GridContainer"/>, 节点路径: MapEditorCreateMark.ExpandPanel.ExpandGrid
    /// </summary>
    public ExpandGrid S_ExpandGrid => L_ExpandPanel.L_ExpandGrid;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.MarginContainer"/>, 节点路径: MapEditorCreateMark.ExpandPanel
    /// </summary>
    public ExpandPanel S_ExpandPanel => L_ExpandPanel;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.SpinBox"/>, 节点路径: MapEditorCreateMark.NumberBar.NumInput
    /// </summary>
    public NumInput S_NumInput => L_NumberBar.L_NumInput;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="UI.MapEditorCreateMark.NumberAttribute"/>, 节点路径: MapEditorCreateMark.NumberBar
    /// </summary>
    public NumberBar S_NumberBar => L_NumberBar;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.OptionButton"/>, 节点路径: MapEditorCreateMark.OptionBar.OptionInput
    /// </summary>
    public OptionInput S_OptionInput => L_OptionBar.L_OptionInput;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="UI.MapEditorCreateMark.OptionAttribute"/>, 节点路径: MapEditorCreateMark.OptionBar
    /// </summary>
    public OptionBar S_OptionBar => L_OptionBar;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Button"/>, 节点路径: MapEditorCreateMark.ObjectBar.HBoxContainer.SelectButton
    /// </summary>
    public SelectButton S_SelectButton => L_ObjectBar.L_HBoxContainer.L_SelectButton;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.TextureRect"/>, 节点路径: MapEditorCreateMark.ObjectBar.HBoxContainer.ObjectIcon
    /// </summary>
    public ObjectIcon S_ObjectIcon => L_ObjectBar.L_HBoxContainer.L_ObjectIcon;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Label"/>, 节点路径: MapEditorCreateMark.ObjectBar.HBoxContainer.ObjectName
    /// </summary>
    public ObjectName S_ObjectName => L_ObjectBar.L_HBoxContainer.L_ObjectName;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="UI.MapEditorCreateMark.ObjectAttribute"/>, 节点路径: MapEditorCreateMark.ObjectBar
    /// </summary>
    public ObjectBar S_ObjectBar => L_ObjectBar;

}
