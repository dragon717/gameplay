namespace UI.MapEditorProject;

/// <summary>
/// Ui代码, 该类是根据ui场景自动生成的, 请不要手动编辑该类, 以免造成代码丢失
/// </summary>
public abstract partial class MapEditorProject : UiBase
{
    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: MapEditorProject.HBoxContainer
    /// </summary>
    public HBoxContainer L_HBoxContainer
    {
        get
        {
            if (_L_HBoxContainer == null) _L_HBoxContainer = new HBoxContainer((MapEditorProjectPanel)this, GetNode<Godot.HBoxContainer>("HBoxContainer"));
            return _L_HBoxContainer;
        }
    }
    private HBoxContainer _L_HBoxContainer;


    public MapEditorProject() : base(nameof(MapEditorProject))
    {
    }

    public sealed override void OnInitNestedUi()
    {

    }

    /// <summary>
    /// 类型: <see cref="Godot.LineEdit"/>, 路径: MapEditorProject.HBoxContainer.Panel.MarginContainer.VBoxContainer.HBoxContainer.GroupSearchInput
    /// </summary>
    public class GroupSearchInput : UiNode<MapEditorProjectPanel, Godot.LineEdit, GroupSearchInput>
    {
        public GroupSearchInput(MapEditorProjectPanel uiPanel, Godot.LineEdit node) : base(uiPanel, node) {  }
        public override GroupSearchInput Clone() => new (UiPanel, (Godot.LineEdit)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Button"/>, 路径: MapEditorProject.HBoxContainer.Panel.MarginContainer.VBoxContainer.HBoxContainer.GroupSearchButton
    /// </summary>
    public class GroupSearchButton : UiNode<MapEditorProjectPanel, Godot.Button, GroupSearchButton>
    {
        public GroupSearchButton(MapEditorProjectPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override GroupSearchButton Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: MapEditorProject.HBoxContainer.Panel.MarginContainer.VBoxContainer.HBoxContainer
    /// </summary>
    public class HBoxContainer_1 : UiNode<MapEditorProjectPanel, Godot.HBoxContainer, HBoxContainer_1>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.LineEdit"/>, 节点路径: MapEditorProject.HBoxContainer.Panel.MarginContainer.VBoxContainer.GroupSearchInput
        /// </summary>
        public GroupSearchInput L_GroupSearchInput
        {
            get
            {
                if (_L_GroupSearchInput == null) _L_GroupSearchInput = new GroupSearchInput(UiPanel, Instance.GetNode<Godot.LineEdit>("GroupSearchInput"));
                return _L_GroupSearchInput;
            }
        }
        private GroupSearchInput _L_GroupSearchInput;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Button"/>, 节点路径: MapEditorProject.HBoxContainer.Panel.MarginContainer.VBoxContainer.GroupSearchButton
        /// </summary>
        public GroupSearchButton L_GroupSearchButton
        {
            get
            {
                if (_L_GroupSearchButton == null) _L_GroupSearchButton = new GroupSearchButton(UiPanel, Instance.GetNode<Godot.Button>("GroupSearchButton"));
                return _L_GroupSearchButton;
            }
        }
        private GroupSearchButton _L_GroupSearchButton;

        public HBoxContainer_1(MapEditorProjectPanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override HBoxContainer_1 Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Button"/>, 路径: MapEditorProject.HBoxContainer.Panel.MarginContainer.VBoxContainer.HBoxContainer2.GroupAddButton
    /// </summary>
    public class GroupAddButton : UiNode<MapEditorProjectPanel, Godot.Button, GroupAddButton>
    {
        public GroupAddButton(MapEditorProjectPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override GroupAddButton Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Button"/>, 路径: MapEditorProject.HBoxContainer.Panel.MarginContainer.VBoxContainer.HBoxContainer2.GroupEditButton
    /// </summary>
    public class GroupEditButton : UiNode<MapEditorProjectPanel, Godot.Button, GroupEditButton>
    {
        public GroupEditButton(MapEditorProjectPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override GroupEditButton Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Button"/>, 路径: MapEditorProject.HBoxContainer.Panel.MarginContainer.VBoxContainer.HBoxContainer2.GroupDeleteButton
    /// </summary>
    public class GroupDeleteButton : UiNode<MapEditorProjectPanel, Godot.Button, GroupDeleteButton>
    {
        public GroupDeleteButton(MapEditorProjectPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override GroupDeleteButton Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: MapEditorProject.HBoxContainer.Panel.MarginContainer.VBoxContainer.HBoxContainer2
    /// </summary>
    public class HBoxContainer2 : UiNode<MapEditorProjectPanel, Godot.HBoxContainer, HBoxContainer2>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Button"/>, 节点路径: MapEditorProject.HBoxContainer.Panel.MarginContainer.VBoxContainer.GroupAddButton
        /// </summary>
        public GroupAddButton L_GroupAddButton
        {
            get
            {
                if (_L_GroupAddButton == null) _L_GroupAddButton = new GroupAddButton(UiPanel, Instance.GetNode<Godot.Button>("GroupAddButton"));
                return _L_GroupAddButton;
            }
        }
        private GroupAddButton _L_GroupAddButton;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Button"/>, 节点路径: MapEditorProject.HBoxContainer.Panel.MarginContainer.VBoxContainer.GroupEditButton
        /// </summary>
        public GroupEditButton L_GroupEditButton
        {
            get
            {
                if (_L_GroupEditButton == null) _L_GroupEditButton = new GroupEditButton(UiPanel, Instance.GetNode<Godot.Button>("GroupEditButton"));
                return _L_GroupEditButton;
            }
        }
        private GroupEditButton _L_GroupEditButton;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Button"/>, 节点路径: MapEditorProject.HBoxContainer.Panel.MarginContainer.VBoxContainer.GroupDeleteButton
        /// </summary>
        public GroupDeleteButton L_GroupDeleteButton
        {
            get
            {
                if (_L_GroupDeleteButton == null) _L_GroupDeleteButton = new GroupDeleteButton(UiPanel, Instance.GetNode<Godot.Button>("GroupDeleteButton"));
                return _L_GroupDeleteButton;
            }
        }
        private GroupDeleteButton _L_GroupDeleteButton;

        public HBoxContainer2(MapEditorProjectPanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override HBoxContainer2 Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.NinePatchRect"/>, 路径: MapEditorProject.HBoxContainer.Panel.MarginContainer.VBoxContainer.ScrollContainer.GroupButton.SelectTexture
    /// </summary>
    public class SelectTexture : UiNode<MapEditorProjectPanel, Godot.NinePatchRect, SelectTexture>
    {
        public SelectTexture(MapEditorProjectPanel uiPanel, Godot.NinePatchRect node) : base(uiPanel, node) {  }
        public override SelectTexture Clone() => new (UiPanel, (Godot.NinePatchRect)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Button"/>, 路径: MapEditorProject.HBoxContainer.Panel.MarginContainer.VBoxContainer.ScrollContainer.GroupButton
    /// </summary>
    public class GroupButton : UiNode<MapEditorProjectPanel, Godot.Button, GroupButton>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.NinePatchRect"/>, 节点路径: MapEditorProject.HBoxContainer.Panel.MarginContainer.VBoxContainer.ScrollContainer.SelectTexture
        /// </summary>
        public SelectTexture L_SelectTexture
        {
            get
            {
                if (_L_SelectTexture == null) _L_SelectTexture = new SelectTexture(UiPanel, Instance.GetNode<Godot.NinePatchRect>("SelectTexture"));
                return _L_SelectTexture;
            }
        }
        private SelectTexture _L_SelectTexture;

        public GroupButton(MapEditorProjectPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override GroupButton Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.ScrollContainer"/>, 路径: MapEditorProject.HBoxContainer.Panel.MarginContainer.VBoxContainer.ScrollContainer
    /// </summary>
    public class ScrollContainer : UiNode<MapEditorProjectPanel, Godot.ScrollContainer, ScrollContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Button"/>, 节点路径: MapEditorProject.HBoxContainer.Panel.MarginContainer.VBoxContainer.GroupButton
        /// </summary>
        public GroupButton L_GroupButton
        {
            get
            {
                if (_L_GroupButton == null) _L_GroupButton = new GroupButton(UiPanel, Instance.GetNode<Godot.Button>("GroupButton"));
                return _L_GroupButton;
            }
        }
        private GroupButton _L_GroupButton;

        public ScrollContainer(MapEditorProjectPanel uiPanel, Godot.ScrollContainer node) : base(uiPanel, node) {  }
        public override ScrollContainer Clone() => new (UiPanel, (Godot.ScrollContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.VBoxContainer"/>, 路径: MapEditorProject.HBoxContainer.Panel.MarginContainer.VBoxContainer
    /// </summary>
    public class VBoxContainer : UiNode<MapEditorProjectPanel, Godot.VBoxContainer, VBoxContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: MapEditorProject.HBoxContainer.Panel.MarginContainer.HBoxContainer
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
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: MapEditorProject.HBoxContainer.Panel.MarginContainer.HBoxContainer2
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
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.ScrollContainer"/>, 节点路径: MapEditorProject.HBoxContainer.Panel.MarginContainer.ScrollContainer
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

        public VBoxContainer(MapEditorProjectPanel uiPanel, Godot.VBoxContainer node) : base(uiPanel, node) {  }
        public override VBoxContainer Clone() => new (UiPanel, (Godot.VBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.MarginContainer"/>, 路径: MapEditorProject.HBoxContainer.Panel.MarginContainer
    /// </summary>
    public class MarginContainer : UiNode<MapEditorProjectPanel, Godot.MarginContainer, MarginContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: MapEditorProject.HBoxContainer.Panel.VBoxContainer
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

        public MarginContainer(MapEditorProjectPanel uiPanel, Godot.MarginContainer node) : base(uiPanel, node) {  }
        public override MarginContainer Clone() => new (UiPanel, (Godot.MarginContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Panel"/>, 路径: MapEditorProject.HBoxContainer.Panel
    /// </summary>
    public class Panel : UiNode<MapEditorProjectPanel, Godot.Panel, Panel>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.MarginContainer"/>, 节点路径: MapEditorProject.HBoxContainer.MarginContainer
        /// </summary>
        public MarginContainer L_MarginContainer
        {
            get
            {
                if (_L_MarginContainer == null) _L_MarginContainer = new MarginContainer(UiPanel, Instance.GetNode<Godot.MarginContainer>("MarginContainer"));
                return _L_MarginContainer;
            }
        }
        private MarginContainer _L_MarginContainer;

        public Panel(MapEditorProjectPanel uiPanel, Godot.Panel node) : base(uiPanel, node) {  }
        public override Panel Clone() => new (UiPanel, (Godot.Panel)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.LineEdit"/>, 路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer.VBoxContainer.HBoxContainer.RoomSearchInput
    /// </summary>
    public class RoomSearchInput : UiNode<MapEditorProjectPanel, Godot.LineEdit, RoomSearchInput>
    {
        public RoomSearchInput(MapEditorProjectPanel uiPanel, Godot.LineEdit node) : base(uiPanel, node) {  }
        public override RoomSearchInput Clone() => new (UiPanel, (Godot.LineEdit)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.OptionButton"/>, 路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer.VBoxContainer.HBoxContainer.RoomTypeButton
    /// </summary>
    public class RoomTypeButton : UiNode<MapEditorProjectPanel, Godot.OptionButton, RoomTypeButton>
    {
        public RoomTypeButton(MapEditorProjectPanel uiPanel, Godot.OptionButton node) : base(uiPanel, node) {  }
        public override RoomTypeButton Clone() => new (UiPanel, (Godot.OptionButton)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Button"/>, 路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer.VBoxContainer.HBoxContainer.RoomSearchButton
    /// </summary>
    public class RoomSearchButton : UiNode<MapEditorProjectPanel, Godot.Button, RoomSearchButton>
    {
        public RoomSearchButton(MapEditorProjectPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override RoomSearchButton Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Button"/>, 路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer.VBoxContainer.HBoxContainer.RoomAddButton
    /// </summary>
    public class RoomAddButton : UiNode<MapEditorProjectPanel, Godot.Button, RoomAddButton>
    {
        public RoomAddButton(MapEditorProjectPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override RoomAddButton Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Button"/>, 路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer.VBoxContainer.HBoxContainer.RoomEditButton
    /// </summary>
    public class RoomEditButton : UiNode<MapEditorProjectPanel, Godot.Button, RoomEditButton>
    {
        public RoomEditButton(MapEditorProjectPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override RoomEditButton Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Button"/>, 路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer.VBoxContainer.HBoxContainer.RoomDeleteButton
    /// </summary>
    public class RoomDeleteButton : UiNode<MapEditorProjectPanel, Godot.Button, RoomDeleteButton>
    {
        public RoomDeleteButton(MapEditorProjectPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override RoomDeleteButton Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer.VBoxContainer.HBoxContainer
    /// </summary>
    public class HBoxContainer_2 : UiNode<MapEditorProjectPanel, Godot.HBoxContainer, HBoxContainer_2>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.LineEdit"/>, 节点路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer.VBoxContainer.RoomSearchInput
        /// </summary>
        public RoomSearchInput L_RoomSearchInput
        {
            get
            {
                if (_L_RoomSearchInput == null) _L_RoomSearchInput = new RoomSearchInput(UiPanel, Instance.GetNode<Godot.LineEdit>("RoomSearchInput"));
                return _L_RoomSearchInput;
            }
        }
        private RoomSearchInput _L_RoomSearchInput;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.OptionButton"/>, 节点路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer.VBoxContainer.RoomTypeButton
        /// </summary>
        public RoomTypeButton L_RoomTypeButton
        {
            get
            {
                if (_L_RoomTypeButton == null) _L_RoomTypeButton = new RoomTypeButton(UiPanel, Instance.GetNode<Godot.OptionButton>("RoomTypeButton"));
                return _L_RoomTypeButton;
            }
        }
        private RoomTypeButton _L_RoomTypeButton;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Button"/>, 节点路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer.VBoxContainer.RoomSearchButton
        /// </summary>
        public RoomSearchButton L_RoomSearchButton
        {
            get
            {
                if (_L_RoomSearchButton == null) _L_RoomSearchButton = new RoomSearchButton(UiPanel, Instance.GetNode<Godot.Button>("RoomSearchButton"));
                return _L_RoomSearchButton;
            }
        }
        private RoomSearchButton _L_RoomSearchButton;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Button"/>, 节点路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer.VBoxContainer.RoomAddButton
        /// </summary>
        public RoomAddButton L_RoomAddButton
        {
            get
            {
                if (_L_RoomAddButton == null) _L_RoomAddButton = new RoomAddButton(UiPanel, Instance.GetNode<Godot.Button>("RoomAddButton"));
                return _L_RoomAddButton;
            }
        }
        private RoomAddButton _L_RoomAddButton;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Button"/>, 节点路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer.VBoxContainer.RoomEditButton
        /// </summary>
        public RoomEditButton L_RoomEditButton
        {
            get
            {
                if (_L_RoomEditButton == null) _L_RoomEditButton = new RoomEditButton(UiPanel, Instance.GetNode<Godot.Button>("RoomEditButton"));
                return _L_RoomEditButton;
            }
        }
        private RoomEditButton _L_RoomEditButton;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Button"/>, 节点路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer.VBoxContainer.RoomDeleteButton
        /// </summary>
        public RoomDeleteButton L_RoomDeleteButton
        {
            get
            {
                if (_L_RoomDeleteButton == null) _L_RoomDeleteButton = new RoomDeleteButton(UiPanel, Instance.GetNode<Godot.Button>("RoomDeleteButton"));
                return _L_RoomDeleteButton;
            }
        }
        private RoomDeleteButton _L_RoomDeleteButton;

        public HBoxContainer_2(MapEditorProjectPanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override HBoxContainer_2 Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.TextureRect"/>, 路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer.VBoxContainer.ScrollContainer.RoomButton.PreviewImage
    /// </summary>
    public class PreviewImage : UiNode<MapEditorProjectPanel, Godot.TextureRect, PreviewImage>
    {
        public PreviewImage(MapEditorProjectPanel uiPanel, Godot.TextureRect node) : base(uiPanel, node) {  }
        public override PreviewImage Clone() => new (UiPanel, (Godot.TextureRect)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer.VBoxContainer.ScrollContainer.RoomButton.RoomName
    /// </summary>
    public class RoomName : UiNode<MapEditorProjectPanel, Godot.Label, RoomName>
    {
        public RoomName(MapEditorProjectPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override RoomName Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer.VBoxContainer.ScrollContainer.RoomButton.RoomType
    /// </summary>
    public class RoomType : UiNode<MapEditorProjectPanel, Godot.Label, RoomType>
    {
        public RoomType(MapEditorProjectPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override RoomType Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.NinePatchRect"/>, 路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer.VBoxContainer.ScrollContainer.RoomButton.SelectTexture
    /// </summary>
    public class SelectTexture_1 : UiNode<MapEditorProjectPanel, Godot.NinePatchRect, SelectTexture_1>
    {
        public SelectTexture_1(MapEditorProjectPanel uiPanel, Godot.NinePatchRect node) : base(uiPanel, node) {  }
        public override SelectTexture_1 Clone() => new (UiPanel, (Godot.NinePatchRect)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.TextureRect"/>, 路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer.VBoxContainer.ScrollContainer.RoomButton.ErrorTexture
    /// </summary>
    public class ErrorTexture : UiNode<MapEditorProjectPanel, Godot.TextureRect, ErrorTexture>
    {
        public ErrorTexture(MapEditorProjectPanel uiPanel, Godot.TextureRect node) : base(uiPanel, node) {  }
        public override ErrorTexture Clone() => new (UiPanel, (Godot.TextureRect)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Button"/>, 路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer.VBoxContainer.ScrollContainer.RoomButton
    /// </summary>
    public class RoomButton : UiNode<MapEditorProjectPanel, Godot.Button, RoomButton>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.TextureRect"/>, 节点路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer.VBoxContainer.ScrollContainer.PreviewImage
        /// </summary>
        public PreviewImage L_PreviewImage
        {
            get
            {
                if (_L_PreviewImage == null) _L_PreviewImage = new PreviewImage(UiPanel, Instance.GetNode<Godot.TextureRect>("PreviewImage"));
                return _L_PreviewImage;
            }
        }
        private PreviewImage _L_PreviewImage;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer.VBoxContainer.ScrollContainer.RoomName
        /// </summary>
        public RoomName L_RoomName
        {
            get
            {
                if (_L_RoomName == null) _L_RoomName = new RoomName(UiPanel, Instance.GetNode<Godot.Label>("RoomName"));
                return _L_RoomName;
            }
        }
        private RoomName _L_RoomName;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer.VBoxContainer.ScrollContainer.RoomType
        /// </summary>
        public RoomType L_RoomType
        {
            get
            {
                if (_L_RoomType == null) _L_RoomType = new RoomType(UiPanel, Instance.GetNode<Godot.Label>("RoomType"));
                return _L_RoomType;
            }
        }
        private RoomType _L_RoomType;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.NinePatchRect"/>, 节点路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer.VBoxContainer.ScrollContainer.SelectTexture
        /// </summary>
        public SelectTexture_1 L_SelectTexture
        {
            get
            {
                if (_L_SelectTexture == null) _L_SelectTexture = new SelectTexture_1(UiPanel, Instance.GetNode<Godot.NinePatchRect>("SelectTexture"));
                return _L_SelectTexture;
            }
        }
        private SelectTexture_1 _L_SelectTexture;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.TextureRect"/>, 节点路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer.VBoxContainer.ScrollContainer.ErrorTexture
        /// </summary>
        public ErrorTexture L_ErrorTexture
        {
            get
            {
                if (_L_ErrorTexture == null) _L_ErrorTexture = new ErrorTexture(UiPanel, Instance.GetNode<Godot.TextureRect>("ErrorTexture"));
                return _L_ErrorTexture;
            }
        }
        private ErrorTexture _L_ErrorTexture;

        public RoomButton(MapEditorProjectPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override RoomButton Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.ScrollContainer"/>, 路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer.VBoxContainer.ScrollContainer
    /// </summary>
    public class ScrollContainer_1 : UiNode<MapEditorProjectPanel, Godot.ScrollContainer, ScrollContainer_1>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Button"/>, 节点路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer.VBoxContainer.RoomButton
        /// </summary>
        public RoomButton L_RoomButton
        {
            get
            {
                if (_L_RoomButton == null) _L_RoomButton = new RoomButton(UiPanel, Instance.GetNode<Godot.Button>("RoomButton"));
                return _L_RoomButton;
            }
        }
        private RoomButton _L_RoomButton;

        public ScrollContainer_1(MapEditorProjectPanel uiPanel, Godot.ScrollContainer node) : base(uiPanel, node) {  }
        public override ScrollContainer_1 Clone() => new (UiPanel, (Godot.ScrollContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.VBoxContainer"/>, 路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer.VBoxContainer
    /// </summary>
    public class VBoxContainer_1 : UiNode<MapEditorProjectPanel, Godot.VBoxContainer, VBoxContainer_1>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer.HBoxContainer
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
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.ScrollContainer"/>, 节点路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer.ScrollContainer
        /// </summary>
        public ScrollContainer_1 L_ScrollContainer
        {
            get
            {
                if (_L_ScrollContainer == null) _L_ScrollContainer = new ScrollContainer_1(UiPanel, Instance.GetNode<Godot.ScrollContainer>("ScrollContainer"));
                return _L_ScrollContainer;
            }
        }
        private ScrollContainer_1 _L_ScrollContainer;

        public VBoxContainer_1(MapEditorProjectPanel uiPanel, Godot.VBoxContainer node) : base(uiPanel, node) {  }
        public override VBoxContainer_1 Clone() => new (UiPanel, (Godot.VBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.MarginContainer"/>, 路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer
    /// </summary>
    public class MarginContainer_1 : UiNode<MapEditorProjectPanel, Godot.MarginContainer, MarginContainer_1>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: MapEditorProject.HBoxContainer.Panel2.VBoxContainer
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

        public MarginContainer_1(MapEditorProjectPanel uiPanel, Godot.MarginContainer node) : base(uiPanel, node) {  }
        public override MarginContainer_1 Clone() => new (UiPanel, (Godot.MarginContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Panel"/>, 路径: MapEditorProject.HBoxContainer.Panel2
    /// </summary>
    public class Panel2 : UiNode<MapEditorProjectPanel, Godot.Panel, Panel2>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.MarginContainer"/>, 节点路径: MapEditorProject.HBoxContainer.MarginContainer
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

        public Panel2(MapEditorProjectPanel uiPanel, Godot.Panel node) : base(uiPanel, node) {  }
        public override Panel2 Clone() => new (UiPanel, (Godot.Panel)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: MapEditorProject.HBoxContainer
    /// </summary>
    public class HBoxContainer : UiNode<MapEditorProjectPanel, Godot.HBoxContainer, HBoxContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Panel"/>, 节点路径: MapEditorProject.Panel
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

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Panel"/>, 节点路径: MapEditorProject.Panel2
        /// </summary>
        public Panel2 L_Panel2
        {
            get
            {
                if (_L_Panel2 == null) _L_Panel2 = new Panel2(UiPanel, Instance.GetNode<Godot.Panel>("Panel2"));
                return _L_Panel2;
            }
        }
        private Panel2 _L_Panel2;

        public HBoxContainer(MapEditorProjectPanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override HBoxContainer Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }


    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.LineEdit"/>, 节点路径: MapEditorProject.HBoxContainer.Panel.MarginContainer.VBoxContainer.HBoxContainer.GroupSearchInput
    /// </summary>
    public GroupSearchInput S_GroupSearchInput => L_HBoxContainer.L_Panel.L_MarginContainer.L_VBoxContainer.L_HBoxContainer.L_GroupSearchInput;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Button"/>, 节点路径: MapEditorProject.HBoxContainer.Panel.MarginContainer.VBoxContainer.HBoxContainer.GroupSearchButton
    /// </summary>
    public GroupSearchButton S_GroupSearchButton => L_HBoxContainer.L_Panel.L_MarginContainer.L_VBoxContainer.L_HBoxContainer.L_GroupSearchButton;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Button"/>, 节点路径: MapEditorProject.HBoxContainer.Panel.MarginContainer.VBoxContainer.HBoxContainer2.GroupAddButton
    /// </summary>
    public GroupAddButton S_GroupAddButton => L_HBoxContainer.L_Panel.L_MarginContainer.L_VBoxContainer.L_HBoxContainer2.L_GroupAddButton;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Button"/>, 节点路径: MapEditorProject.HBoxContainer.Panel.MarginContainer.VBoxContainer.HBoxContainer2.GroupEditButton
    /// </summary>
    public GroupEditButton S_GroupEditButton => L_HBoxContainer.L_Panel.L_MarginContainer.L_VBoxContainer.L_HBoxContainer2.L_GroupEditButton;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Button"/>, 节点路径: MapEditorProject.HBoxContainer.Panel.MarginContainer.VBoxContainer.HBoxContainer2.GroupDeleteButton
    /// </summary>
    public GroupDeleteButton S_GroupDeleteButton => L_HBoxContainer.L_Panel.L_MarginContainer.L_VBoxContainer.L_HBoxContainer2.L_GroupDeleteButton;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: MapEditorProject.HBoxContainer.Panel.MarginContainer.VBoxContainer.HBoxContainer2
    /// </summary>
    public HBoxContainer2 S_HBoxContainer2 => L_HBoxContainer.L_Panel.L_MarginContainer.L_VBoxContainer.L_HBoxContainer2;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Button"/>, 节点路径: MapEditorProject.HBoxContainer.Panel.MarginContainer.VBoxContainer.ScrollContainer.GroupButton
    /// </summary>
    public GroupButton S_GroupButton => L_HBoxContainer.L_Panel.L_MarginContainer.L_VBoxContainer.L_ScrollContainer.L_GroupButton;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Panel"/>, 节点路径: MapEditorProject.HBoxContainer.Panel
    /// </summary>
    public Panel S_Panel => L_HBoxContainer.L_Panel;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.LineEdit"/>, 节点路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer.VBoxContainer.HBoxContainer.RoomSearchInput
    /// </summary>
    public RoomSearchInput S_RoomSearchInput => L_HBoxContainer.L_Panel2.L_MarginContainer.L_VBoxContainer.L_HBoxContainer.L_RoomSearchInput;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.OptionButton"/>, 节点路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer.VBoxContainer.HBoxContainer.RoomTypeButton
    /// </summary>
    public RoomTypeButton S_RoomTypeButton => L_HBoxContainer.L_Panel2.L_MarginContainer.L_VBoxContainer.L_HBoxContainer.L_RoomTypeButton;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Button"/>, 节点路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer.VBoxContainer.HBoxContainer.RoomSearchButton
    /// </summary>
    public RoomSearchButton S_RoomSearchButton => L_HBoxContainer.L_Panel2.L_MarginContainer.L_VBoxContainer.L_HBoxContainer.L_RoomSearchButton;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Button"/>, 节点路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer.VBoxContainer.HBoxContainer.RoomAddButton
    /// </summary>
    public RoomAddButton S_RoomAddButton => L_HBoxContainer.L_Panel2.L_MarginContainer.L_VBoxContainer.L_HBoxContainer.L_RoomAddButton;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Button"/>, 节点路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer.VBoxContainer.HBoxContainer.RoomEditButton
    /// </summary>
    public RoomEditButton S_RoomEditButton => L_HBoxContainer.L_Panel2.L_MarginContainer.L_VBoxContainer.L_HBoxContainer.L_RoomEditButton;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Button"/>, 节点路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer.VBoxContainer.HBoxContainer.RoomDeleteButton
    /// </summary>
    public RoomDeleteButton S_RoomDeleteButton => L_HBoxContainer.L_Panel2.L_MarginContainer.L_VBoxContainer.L_HBoxContainer.L_RoomDeleteButton;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.TextureRect"/>, 节点路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer.VBoxContainer.ScrollContainer.RoomButton.PreviewImage
    /// </summary>
    public PreviewImage S_PreviewImage => L_HBoxContainer.L_Panel2.L_MarginContainer.L_VBoxContainer.L_ScrollContainer.L_RoomButton.L_PreviewImage;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Label"/>, 节点路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer.VBoxContainer.ScrollContainer.RoomButton.RoomName
    /// </summary>
    public RoomName S_RoomName => L_HBoxContainer.L_Panel2.L_MarginContainer.L_VBoxContainer.L_ScrollContainer.L_RoomButton.L_RoomName;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Label"/>, 节点路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer.VBoxContainer.ScrollContainer.RoomButton.RoomType
    /// </summary>
    public RoomType S_RoomType => L_HBoxContainer.L_Panel2.L_MarginContainer.L_VBoxContainer.L_ScrollContainer.L_RoomButton.L_RoomType;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.TextureRect"/>, 节点路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer.VBoxContainer.ScrollContainer.RoomButton.ErrorTexture
    /// </summary>
    public ErrorTexture S_ErrorTexture => L_HBoxContainer.L_Panel2.L_MarginContainer.L_VBoxContainer.L_ScrollContainer.L_RoomButton.L_ErrorTexture;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Button"/>, 节点路径: MapEditorProject.HBoxContainer.Panel2.MarginContainer.VBoxContainer.ScrollContainer.RoomButton
    /// </summary>
    public RoomButton S_RoomButton => L_HBoxContainer.L_Panel2.L_MarginContainer.L_VBoxContainer.L_ScrollContainer.L_RoomButton;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Panel"/>, 节点路径: MapEditorProject.HBoxContainer.Panel2
    /// </summary>
    public Panel2 S_Panel2 => L_HBoxContainer.L_Panel2;

}
