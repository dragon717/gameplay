namespace UI.TileSetEditorCombination;

/// <summary>
/// Ui代码, 该类是根据ui场景自动生成的, 请不要手动编辑该类, 以免造成代码丢失
/// </summary>
public abstract partial class TileSetEditorCombination : UiBase
{
    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HSplitContainer"/>, 节点路径: TileSetEditorCombination.HSplitContainer
    /// </summary>
    public HSplitContainer L_HSplitContainer
    {
        get
        {
            if (_L_HSplitContainer == null) _L_HSplitContainer = new HSplitContainer((TileSetEditorCombinationPanel)this, GetNode<Godot.HSplitContainer>("HSplitContainer"));
            return _L_HSplitContainer;
        }
    }
    private HSplitContainer _L_HSplitContainer;


    public TileSetEditorCombination() : base(nameof(TileSetEditorCombination))
    {
    }

    public sealed override void OnInitNestedUi()
    {
        _ = L_HSplitContainer.L_VSplitContainer.L_LeftTop.L_MarginContainer.L_LeftTopBg;
        _ = L_HSplitContainer.L_VSplitContainer.L_LeftBottom.L_MarginContainer.L_LeftBottomBg;
        _ = L_HSplitContainer.L_Right.L_MarginContainer.L_RightBg;

    }

    /// <summary>
    /// 类型: <see cref="Godot.Node2D"/>, 路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftTop.MarginContainer.LeftTopBg.CombinationRoot.CanvasRoot
    /// </summary>
    public class CanvasRoot : UiNode<TileSetEditorCombinationPanel, Godot.Node2D, CanvasRoot>
    {
        public CanvasRoot(TileSetEditorCombinationPanel uiPanel, Godot.Node2D node) : base(uiPanel, node) {  }
        public override CanvasRoot Clone() => new (UiPanel, (Godot.Node2D)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Node2D"/>, 路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftTop.MarginContainer.LeftTopBg.CombinationRoot.BrushRoot
    /// </summary>
    public class BrushRoot : UiNode<TileSetEditorCombinationPanel, Godot.Node2D, BrushRoot>
    {
        public BrushRoot(TileSetEditorCombinationPanel uiPanel, Godot.Node2D node) : base(uiPanel, node) {  }
        public override BrushRoot Clone() => new (UiPanel, (Godot.Node2D)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="UI.TileSetEditorCombination.RectBrush"/>, 路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftTop.MarginContainer.LeftTopBg.CombinationRoot.RectBrush
    /// </summary>
    public class RectBrush : UiNode<TileSetEditorCombinationPanel, UI.TileSetEditorCombination.RectBrush, RectBrush>
    {
        public RectBrush(TileSetEditorCombinationPanel uiPanel, UI.TileSetEditorCombination.RectBrush node) : base(uiPanel, node) {  }
        public override RectBrush Clone() => new (UiPanel, (UI.TileSetEditorCombination.RectBrush)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Control"/>, 路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftTop.MarginContainer.LeftTopBg.CombinationRoot
    /// </summary>
    public class CombinationRoot : UiNode<TileSetEditorCombinationPanel, Godot.Control, CombinationRoot>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Node2D"/>, 节点路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftTop.MarginContainer.LeftTopBg.CanvasRoot
        /// </summary>
        public CanvasRoot L_CanvasRoot
        {
            get
            {
                if (_L_CanvasRoot == null) _L_CanvasRoot = new CanvasRoot(UiPanel, Instance.GetNode<Godot.Node2D>("CanvasRoot"));
                return _L_CanvasRoot;
            }
        }
        private CanvasRoot _L_CanvasRoot;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Node2D"/>, 节点路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftTop.MarginContainer.LeftTopBg.BrushRoot
        /// </summary>
        public BrushRoot L_BrushRoot
        {
            get
            {
                if (_L_BrushRoot == null) _L_BrushRoot = new BrushRoot(UiPanel, Instance.GetNode<Godot.Node2D>("BrushRoot"));
                return _L_BrushRoot;
            }
        }
        private BrushRoot _L_BrushRoot;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="UI.TileSetEditorCombination.RectBrush"/>, 节点路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftTop.MarginContainer.LeftTopBg.RectBrush
        /// </summary>
        public RectBrush L_RectBrush
        {
            get
            {
                if (_L_RectBrush == null) _L_RectBrush = new RectBrush(UiPanel, Instance.GetNode<UI.TileSetEditorCombination.RectBrush>("RectBrush"));
                return _L_RectBrush;
            }
        }
        private RectBrush _L_RectBrush;

        public CombinationRoot(TileSetEditorCombinationPanel uiPanel, Godot.Control node) : base(uiPanel, node) {  }
        public override CombinationRoot Clone() => new (UiPanel, (Godot.Control)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.ColorRect"/>, 路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftTop.MarginContainer.LeftTopBg.Grid
    /// </summary>
    public class Grid : UiNode<TileSetEditorCombinationPanel, Godot.ColorRect, Grid>
    {
        public Grid(TileSetEditorCombinationPanel uiPanel, Godot.ColorRect node) : base(uiPanel, node) {  }
        public override Grid Clone() => new (UiPanel, (Godot.ColorRect)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.TextureButton"/>, 路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftTop.MarginContainer.LeftTopBg.FocusBtn
    /// </summary>
    public class FocusBtn : UiNode<TileSetEditorCombinationPanel, Godot.TextureButton, FocusBtn>
    {
        public FocusBtn(TileSetEditorCombinationPanel uiPanel, Godot.TextureButton node) : base(uiPanel, node) {  }
        public override FocusBtn Clone() => new (UiPanel, (Godot.TextureButton)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.TextureButton"/>, 路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftTop.MarginContainer.LeftTopBg.DeleteBtn
    /// </summary>
    public class DeleteBtn : UiNode<TileSetEditorCombinationPanel, Godot.TextureButton, DeleteBtn>
    {
        public DeleteBtn(TileSetEditorCombinationPanel uiPanel, Godot.TextureButton node) : base(uiPanel, node) {  }
        public override DeleteBtn Clone() => new (UiPanel, (Godot.TextureButton)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Button"/>, 路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftTop.MarginContainer.LeftTopBg.ImportBtn
    /// </summary>
    public class ImportBtn : UiNode<TileSetEditorCombinationPanel, Godot.Button, ImportBtn>
    {
        public ImportBtn(TileSetEditorCombinationPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override ImportBtn Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="UI.TileSetEditorCombination.TileEditCombination"/>, 路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftTop.MarginContainer.LeftTopBg
    /// </summary>
    public class LeftTopBg : UiNode<TileSetEditorCombinationPanel, UI.TileSetEditorCombination.TileEditCombination, LeftTopBg>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Control"/>, 节点路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftTop.MarginContainer.CombinationRoot
        /// </summary>
        public CombinationRoot L_CombinationRoot
        {
            get
            {
                if (_L_CombinationRoot == null) _L_CombinationRoot = new CombinationRoot(UiPanel, Instance.GetNode<Godot.Control>("CombinationRoot"));
                return _L_CombinationRoot;
            }
        }
        private CombinationRoot _L_CombinationRoot;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.ColorRect"/>, 节点路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftTop.MarginContainer.Grid
        /// </summary>
        public Grid L_Grid
        {
            get
            {
                if (_L_Grid == null) _L_Grid = new Grid(UiPanel, Instance.GetNode<Godot.ColorRect>("Grid"));
                return _L_Grid;
            }
        }
        private Grid _L_Grid;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.TextureButton"/>, 节点路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftTop.MarginContainer.FocusBtn
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

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.TextureButton"/>, 节点路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftTop.MarginContainer.DeleteBtn
        /// </summary>
        public DeleteBtn L_DeleteBtn
        {
            get
            {
                if (_L_DeleteBtn == null) _L_DeleteBtn = new DeleteBtn(UiPanel, Instance.GetNode<Godot.TextureButton>("DeleteBtn"));
                return _L_DeleteBtn;
            }
        }
        private DeleteBtn _L_DeleteBtn;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Button"/>, 节点路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftTop.MarginContainer.ImportBtn
        /// </summary>
        public ImportBtn L_ImportBtn
        {
            get
            {
                if (_L_ImportBtn == null) _L_ImportBtn = new ImportBtn(UiPanel, Instance.GetNode<Godot.Button>("ImportBtn"));
                return _L_ImportBtn;
            }
        }
        private ImportBtn _L_ImportBtn;

        public LeftTopBg(TileSetEditorCombinationPanel uiPanel, UI.TileSetEditorCombination.TileEditCombination node) : base(uiPanel, node) {  }
        public override LeftTopBg Clone() => new (UiPanel, (UI.TileSetEditorCombination.TileEditCombination)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.MarginContainer"/>, 路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftTop.MarginContainer
    /// </summary>
    public class MarginContainer : UiNode<TileSetEditorCombinationPanel, Godot.MarginContainer, MarginContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="UI.TileSetEditorCombination.TileEditCombination"/>, 节点路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftTop.LeftTopBg
        /// </summary>
        public LeftTopBg L_LeftTopBg
        {
            get
            {
                if (_L_LeftTopBg == null) _L_LeftTopBg = new LeftTopBg(UiPanel, Instance.GetNode<UI.TileSetEditorCombination.TileEditCombination>("LeftTopBg"));
                return _L_LeftTopBg;
            }
        }
        private LeftTopBg _L_LeftTopBg;

        public MarginContainer(TileSetEditorCombinationPanel uiPanel, Godot.MarginContainer node) : base(uiPanel, node) {  }
        public override MarginContainer Clone() => new (UiPanel, (Godot.MarginContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Panel"/>, 路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftTop
    /// </summary>
    public class LeftTop : UiNode<TileSetEditorCombinationPanel, Godot.Panel, LeftTop>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.MarginContainer"/>, 节点路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.MarginContainer
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

        public LeftTop(TileSetEditorCombinationPanel uiPanel, Godot.Panel node) : base(uiPanel, node) {  }
        public override LeftTop Clone() => new (UiPanel, (Godot.Panel)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.ColorRect"/>, 路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftBottom.MarginContainer.LeftBottomBg.TileTexture.MaskRoot.MaskRect
    /// </summary>
    public class MaskRect : UiNode<TileSetEditorCombinationPanel, Godot.ColorRect, MaskRect>
    {
        public MaskRect(TileSetEditorCombinationPanel uiPanel, Godot.ColorRect node) : base(uiPanel, node) {  }
        public override MaskRect Clone() => new (UiPanel, (Godot.ColorRect)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Control"/>, 路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftBottom.MarginContainer.LeftBottomBg.TileTexture.MaskRoot
    /// </summary>
    public class MaskRoot : UiNode<TileSetEditorCombinationPanel, Godot.Control, MaskRoot>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.ColorRect"/>, 节点路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftBottom.MarginContainer.LeftBottomBg.TileTexture.MaskRect
        /// </summary>
        public MaskRect L_MaskRect
        {
            get
            {
                if (_L_MaskRect == null) _L_MaskRect = new MaskRect(UiPanel, Instance.GetNode<Godot.ColorRect>("MaskRect"));
                return _L_MaskRect;
            }
        }
        private MaskRect _L_MaskRect;

        public MaskRoot(TileSetEditorCombinationPanel uiPanel, Godot.Control node) : base(uiPanel, node) {  }
        public override MaskRoot Clone() => new (UiPanel, (Godot.Control)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="EditorMaskBrush"/>, 路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftBottom.MarginContainer.LeftBottomBg.TileTexture.MaskBrush
    /// </summary>
    public class MaskBrush : UiNode<TileSetEditorCombinationPanel, EditorMaskBrush, MaskBrush>
    {
        public MaskBrush(TileSetEditorCombinationPanel uiPanel, EditorMaskBrush node) : base(uiPanel, node) {  }
        public override MaskBrush Clone() => new (UiPanel, (EditorMaskBrush)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.TextureRect"/>, 路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftBottom.MarginContainer.LeftBottomBg.TileTexture
    /// </summary>
    public class TileTexture : UiNode<TileSetEditorCombinationPanel, Godot.TextureRect, TileTexture>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Control"/>, 节点路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftBottom.MarginContainer.LeftBottomBg.MaskRoot
        /// </summary>
        public MaskRoot L_MaskRoot
        {
            get
            {
                if (_L_MaskRoot == null) _L_MaskRoot = new MaskRoot(UiPanel, Instance.GetNode<Godot.Control>("MaskRoot"));
                return _L_MaskRoot;
            }
        }
        private MaskRoot _L_MaskRoot;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="EditorMaskBrush"/>, 节点路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftBottom.MarginContainer.LeftBottomBg.MaskBrush
        /// </summary>
        public MaskBrush L_MaskBrush
        {
            get
            {
                if (_L_MaskBrush == null) _L_MaskBrush = new MaskBrush(UiPanel, Instance.GetNode<EditorMaskBrush>("MaskBrush"));
                return _L_MaskBrush;
            }
        }
        private MaskBrush _L_MaskBrush;

        public TileTexture(TileSetEditorCombinationPanel uiPanel, Godot.TextureRect node) : base(uiPanel, node) {  }
        public override TileTexture Clone() => new (UiPanel, (Godot.TextureRect)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.ColorRect"/>, 路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftBottom.MarginContainer.LeftBottomBg.Grid
    /// </summary>
    public class Grid_1 : UiNode<TileSetEditorCombinationPanel, Godot.ColorRect, Grid_1>
    {
        public Grid_1(TileSetEditorCombinationPanel uiPanel, Godot.ColorRect node) : base(uiPanel, node) {  }
        public override Grid_1 Clone() => new (UiPanel, (Godot.ColorRect)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.TextureButton"/>, 路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftBottom.MarginContainer.LeftBottomBg.FocusBtn
    /// </summary>
    public class FocusBtn_1 : UiNode<TileSetEditorCombinationPanel, Godot.TextureButton, FocusBtn_1>
    {
        public FocusBtn_1(TileSetEditorCombinationPanel uiPanel, Godot.TextureButton node) : base(uiPanel, node) {  }
        public override FocusBtn_1 Clone() => new (UiPanel, (Godot.TextureButton)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="UI.TileSetEditorCombination.TileEditArea"/>, 路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftBottom.MarginContainer.LeftBottomBg
    /// </summary>
    public class LeftBottomBg : UiNode<TileSetEditorCombinationPanel, UI.TileSetEditorCombination.TileEditArea, LeftBottomBg>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.TextureRect"/>, 节点路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftBottom.MarginContainer.TileTexture
        /// </summary>
        public TileTexture L_TileTexture
        {
            get
            {
                if (_L_TileTexture == null) _L_TileTexture = new TileTexture(UiPanel, Instance.GetNode<Godot.TextureRect>("TileTexture"));
                return _L_TileTexture;
            }
        }
        private TileTexture _L_TileTexture;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.ColorRect"/>, 节点路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftBottom.MarginContainer.Grid
        /// </summary>
        public Grid_1 L_Grid
        {
            get
            {
                if (_L_Grid == null) _L_Grid = new Grid_1(UiPanel, Instance.GetNode<Godot.ColorRect>("Grid"));
                return _L_Grid;
            }
        }
        private Grid_1 _L_Grid;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.TextureButton"/>, 节点路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftBottom.MarginContainer.FocusBtn
        /// </summary>
        public FocusBtn_1 L_FocusBtn
        {
            get
            {
                if (_L_FocusBtn == null) _L_FocusBtn = new FocusBtn_1(UiPanel, Instance.GetNode<Godot.TextureButton>("FocusBtn"));
                return _L_FocusBtn;
            }
        }
        private FocusBtn_1 _L_FocusBtn;

        public LeftBottomBg(TileSetEditorCombinationPanel uiPanel, UI.TileSetEditorCombination.TileEditArea node) : base(uiPanel, node) {  }
        public override LeftBottomBg Clone() => new (UiPanel, (UI.TileSetEditorCombination.TileEditArea)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.MarginContainer"/>, 路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftBottom.MarginContainer
    /// </summary>
    public class MarginContainer_1 : UiNode<TileSetEditorCombinationPanel, Godot.MarginContainer, MarginContainer_1>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="UI.TileSetEditorCombination.TileEditArea"/>, 节点路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftBottom.LeftBottomBg
        /// </summary>
        public LeftBottomBg L_LeftBottomBg
        {
            get
            {
                if (_L_LeftBottomBg == null) _L_LeftBottomBg = new LeftBottomBg(UiPanel, Instance.GetNode<UI.TileSetEditorCombination.TileEditArea>("LeftBottomBg"));
                return _L_LeftBottomBg;
            }
        }
        private LeftBottomBg _L_LeftBottomBg;

        public MarginContainer_1(TileSetEditorCombinationPanel uiPanel, Godot.MarginContainer node) : base(uiPanel, node) {  }
        public override MarginContainer_1 Clone() => new (UiPanel, (Godot.MarginContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Panel"/>, 路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftBottom
    /// </summary>
    public class LeftBottom : UiNode<TileSetEditorCombinationPanel, Godot.Panel, LeftBottom>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.MarginContainer"/>, 节点路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.MarginContainer
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

        public LeftBottom(TileSetEditorCombinationPanel uiPanel, Godot.Panel node) : base(uiPanel, node) {  }
        public override LeftBottom Clone() => new (UiPanel, (Godot.Panel)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.VSplitContainer"/>, 路径: TileSetEditorCombination.HSplitContainer.VSplitContainer
    /// </summary>
    public class VSplitContainer : UiNode<TileSetEditorCombinationPanel, Godot.VSplitContainer, VSplitContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Panel"/>, 节点路径: TileSetEditorCombination.HSplitContainer.LeftTop
        /// </summary>
        public LeftTop L_LeftTop
        {
            get
            {
                if (_L_LeftTop == null) _L_LeftTop = new LeftTop(UiPanel, Instance.GetNode<Godot.Panel>("LeftTop"));
                return _L_LeftTop;
            }
        }
        private LeftTop _L_LeftTop;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Panel"/>, 节点路径: TileSetEditorCombination.HSplitContainer.LeftBottom
        /// </summary>
        public LeftBottom L_LeftBottom
        {
            get
            {
                if (_L_LeftBottom == null) _L_LeftBottom = new LeftBottom(UiPanel, Instance.GetNode<Godot.Panel>("LeftBottom"));
                return _L_LeftBottom;
            }
        }
        private LeftBottom _L_LeftBottom;

        public VSplitContainer(TileSetEditorCombinationPanel uiPanel, Godot.VSplitContainer node) : base(uiPanel, node) {  }
        public override VSplitContainer Clone() => new (UiPanel, (Godot.VSplitContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: TileSetEditorCombination.HSplitContainer.Right.MarginContainer.RightBg.Label
    /// </summary>
    public class Label : UiNode<TileSetEditorCombinationPanel, Godot.Label, Label>
    {
        public Label(TileSetEditorCombinationPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override Label Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.TextureRect"/>, 路径: TileSetEditorCombination.HSplitContainer.Right.MarginContainer.RightBg.ScrollContainer.CellButton.PreviewImage
    /// </summary>
    public class PreviewImage : UiNode<TileSetEditorCombinationPanel, Godot.TextureRect, PreviewImage>
    {
        public PreviewImage(TileSetEditorCombinationPanel uiPanel, Godot.TextureRect node) : base(uiPanel, node) {  }
        public override PreviewImage Clone() => new (UiPanel, (Godot.TextureRect)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: TileSetEditorCombination.HSplitContainer.Right.MarginContainer.RightBg.ScrollContainer.CellButton.CellName
    /// </summary>
    public class CellName : UiNode<TileSetEditorCombinationPanel, Godot.Label, CellName>
    {
        public CellName(TileSetEditorCombinationPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override CellName Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.NinePatchRect"/>, 路径: TileSetEditorCombination.HSplitContainer.Right.MarginContainer.RightBg.ScrollContainer.CellButton.SelectTexture
    /// </summary>
    public class SelectTexture : UiNode<TileSetEditorCombinationPanel, Godot.NinePatchRect, SelectTexture>
    {
        public SelectTexture(TileSetEditorCombinationPanel uiPanel, Godot.NinePatchRect node) : base(uiPanel, node) {  }
        public override SelectTexture Clone() => new (UiPanel, (Godot.NinePatchRect)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Button"/>, 路径: TileSetEditorCombination.HSplitContainer.Right.MarginContainer.RightBg.ScrollContainer.CellButton
    /// </summary>
    public class CellButton : UiNode<TileSetEditorCombinationPanel, Godot.Button, CellButton>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.TextureRect"/>, 节点路径: TileSetEditorCombination.HSplitContainer.Right.MarginContainer.RightBg.ScrollContainer.PreviewImage
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
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: TileSetEditorCombination.HSplitContainer.Right.MarginContainer.RightBg.ScrollContainer.CellName
        /// </summary>
        public CellName L_CellName
        {
            get
            {
                if (_L_CellName == null) _L_CellName = new CellName(UiPanel, Instance.GetNode<Godot.Label>("CellName"));
                return _L_CellName;
            }
        }
        private CellName _L_CellName;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.NinePatchRect"/>, 节点路径: TileSetEditorCombination.HSplitContainer.Right.MarginContainer.RightBg.ScrollContainer.SelectTexture
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

        public CellButton(TileSetEditorCombinationPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override CellButton Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.ScrollContainer"/>, 路径: TileSetEditorCombination.HSplitContainer.Right.MarginContainer.RightBg.ScrollContainer
    /// </summary>
    public class ScrollContainer : UiNode<TileSetEditorCombinationPanel, Godot.ScrollContainer, ScrollContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Button"/>, 节点路径: TileSetEditorCombination.HSplitContainer.Right.MarginContainer.RightBg.CellButton
        /// </summary>
        public CellButton L_CellButton
        {
            get
            {
                if (_L_CellButton == null) _L_CellButton = new CellButton(UiPanel, Instance.GetNode<Godot.Button>("CellButton"));
                return _L_CellButton;
            }
        }
        private CellButton _L_CellButton;

        public ScrollContainer(TileSetEditorCombinationPanel uiPanel, Godot.ScrollContainer node) : base(uiPanel, node) {  }
        public override ScrollContainer Clone() => new (UiPanel, (Godot.ScrollContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="UI.TileSetEditorCombination.TileSelected"/>, 路径: TileSetEditorCombination.HSplitContainer.Right.MarginContainer.RightBg
    /// </summary>
    public class RightBg : UiNode<TileSetEditorCombinationPanel, UI.TileSetEditorCombination.TileSelected, RightBg>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: TileSetEditorCombination.HSplitContainer.Right.MarginContainer.Label
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
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.ScrollContainer"/>, 节点路径: TileSetEditorCombination.HSplitContainer.Right.MarginContainer.ScrollContainer
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

        public RightBg(TileSetEditorCombinationPanel uiPanel, UI.TileSetEditorCombination.TileSelected node) : base(uiPanel, node) {  }
        public override RightBg Clone() => new (UiPanel, (UI.TileSetEditorCombination.TileSelected)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.MarginContainer"/>, 路径: TileSetEditorCombination.HSplitContainer.Right.MarginContainer
    /// </summary>
    public class MarginContainer_2 : UiNode<TileSetEditorCombinationPanel, Godot.MarginContainer, MarginContainer_2>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="UI.TileSetEditorCombination.TileSelected"/>, 节点路径: TileSetEditorCombination.HSplitContainer.Right.RightBg
        /// </summary>
        public RightBg L_RightBg
        {
            get
            {
                if (_L_RightBg == null) _L_RightBg = new RightBg(UiPanel, Instance.GetNode<UI.TileSetEditorCombination.TileSelected>("RightBg"));
                return _L_RightBg;
            }
        }
        private RightBg _L_RightBg;

        public MarginContainer_2(TileSetEditorCombinationPanel uiPanel, Godot.MarginContainer node) : base(uiPanel, node) {  }
        public override MarginContainer_2 Clone() => new (UiPanel, (Godot.MarginContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Panel"/>, 路径: TileSetEditorCombination.HSplitContainer.Right
    /// </summary>
    public class Right : UiNode<TileSetEditorCombinationPanel, Godot.Panel, Right>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.MarginContainer"/>, 节点路径: TileSetEditorCombination.HSplitContainer.MarginContainer
        /// </summary>
        public MarginContainer_2 L_MarginContainer
        {
            get
            {
                if (_L_MarginContainer == null) _L_MarginContainer = new MarginContainer_2(UiPanel, Instance.GetNode<Godot.MarginContainer>("MarginContainer"));
                return _L_MarginContainer;
            }
        }
        private MarginContainer_2 _L_MarginContainer;

        public Right(TileSetEditorCombinationPanel uiPanel, Godot.Panel node) : base(uiPanel, node) {  }
        public override Right Clone() => new (UiPanel, (Godot.Panel)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HSplitContainer"/>, 路径: TileSetEditorCombination.HSplitContainer
    /// </summary>
    public class HSplitContainer : UiNode<TileSetEditorCombinationPanel, Godot.HSplitContainer, HSplitContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VSplitContainer"/>, 节点路径: TileSetEditorCombination.VSplitContainer
        /// </summary>
        public VSplitContainer L_VSplitContainer
        {
            get
            {
                if (_L_VSplitContainer == null) _L_VSplitContainer = new VSplitContainer(UiPanel, Instance.GetNode<Godot.VSplitContainer>("VSplitContainer"));
                return _L_VSplitContainer;
            }
        }
        private VSplitContainer _L_VSplitContainer;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Panel"/>, 节点路径: TileSetEditorCombination.Right
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

        public HSplitContainer(TileSetEditorCombinationPanel uiPanel, Godot.HSplitContainer node) : base(uiPanel, node) {  }
        public override HSplitContainer Clone() => new (UiPanel, (Godot.HSplitContainer)Instance.Duplicate());
    }


    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Node2D"/>, 节点路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftTop.MarginContainer.LeftTopBg.CombinationRoot.CanvasRoot
    /// </summary>
    public CanvasRoot S_CanvasRoot => L_HSplitContainer.L_VSplitContainer.L_LeftTop.L_MarginContainer.L_LeftTopBg.L_CombinationRoot.L_CanvasRoot;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Node2D"/>, 节点路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftTop.MarginContainer.LeftTopBg.CombinationRoot.BrushRoot
    /// </summary>
    public BrushRoot S_BrushRoot => L_HSplitContainer.L_VSplitContainer.L_LeftTop.L_MarginContainer.L_LeftTopBg.L_CombinationRoot.L_BrushRoot;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="UI.TileSetEditorCombination.RectBrush"/>, 节点路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftTop.MarginContainer.LeftTopBg.CombinationRoot.RectBrush
    /// </summary>
    public RectBrush S_RectBrush => L_HSplitContainer.L_VSplitContainer.L_LeftTop.L_MarginContainer.L_LeftTopBg.L_CombinationRoot.L_RectBrush;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Control"/>, 节点路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftTop.MarginContainer.LeftTopBg.CombinationRoot
    /// </summary>
    public CombinationRoot S_CombinationRoot => L_HSplitContainer.L_VSplitContainer.L_LeftTop.L_MarginContainer.L_LeftTopBg.L_CombinationRoot;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.TextureButton"/>, 节点路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftTop.MarginContainer.LeftTopBg.DeleteBtn
    /// </summary>
    public DeleteBtn S_DeleteBtn => L_HSplitContainer.L_VSplitContainer.L_LeftTop.L_MarginContainer.L_LeftTopBg.L_DeleteBtn;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Button"/>, 节点路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftTop.MarginContainer.LeftTopBg.ImportBtn
    /// </summary>
    public ImportBtn S_ImportBtn => L_HSplitContainer.L_VSplitContainer.L_LeftTop.L_MarginContainer.L_LeftTopBg.L_ImportBtn;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="UI.TileSetEditorCombination.TileEditCombination"/>, 节点路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftTop.MarginContainer.LeftTopBg
    /// </summary>
    public LeftTopBg S_LeftTopBg => L_HSplitContainer.L_VSplitContainer.L_LeftTop.L_MarginContainer.L_LeftTopBg;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Panel"/>, 节点路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftTop
    /// </summary>
    public LeftTop S_LeftTop => L_HSplitContainer.L_VSplitContainer.L_LeftTop;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.ColorRect"/>, 节点路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftBottom.MarginContainer.LeftBottomBg.TileTexture.MaskRoot.MaskRect
    /// </summary>
    public MaskRect S_MaskRect => L_HSplitContainer.L_VSplitContainer.L_LeftBottom.L_MarginContainer.L_LeftBottomBg.L_TileTexture.L_MaskRoot.L_MaskRect;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Control"/>, 节点路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftBottom.MarginContainer.LeftBottomBg.TileTexture.MaskRoot
    /// </summary>
    public MaskRoot S_MaskRoot => L_HSplitContainer.L_VSplitContainer.L_LeftBottom.L_MarginContainer.L_LeftBottomBg.L_TileTexture.L_MaskRoot;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="EditorMaskBrush"/>, 节点路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftBottom.MarginContainer.LeftBottomBg.TileTexture.MaskBrush
    /// </summary>
    public MaskBrush S_MaskBrush => L_HSplitContainer.L_VSplitContainer.L_LeftBottom.L_MarginContainer.L_LeftBottomBg.L_TileTexture.L_MaskBrush;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.TextureRect"/>, 节点路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftBottom.MarginContainer.LeftBottomBg.TileTexture
    /// </summary>
    public TileTexture S_TileTexture => L_HSplitContainer.L_VSplitContainer.L_LeftBottom.L_MarginContainer.L_LeftBottomBg.L_TileTexture;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="UI.TileSetEditorCombination.TileEditArea"/>, 节点路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftBottom.MarginContainer.LeftBottomBg
    /// </summary>
    public LeftBottomBg S_LeftBottomBg => L_HSplitContainer.L_VSplitContainer.L_LeftBottom.L_MarginContainer.L_LeftBottomBg;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Panel"/>, 节点路径: TileSetEditorCombination.HSplitContainer.VSplitContainer.LeftBottom
    /// </summary>
    public LeftBottom S_LeftBottom => L_HSplitContainer.L_VSplitContainer.L_LeftBottom;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.VSplitContainer"/>, 节点路径: TileSetEditorCombination.HSplitContainer.VSplitContainer
    /// </summary>
    public VSplitContainer S_VSplitContainer => L_HSplitContainer.L_VSplitContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Label"/>, 节点路径: TileSetEditorCombination.HSplitContainer.Right.MarginContainer.RightBg.Label
    /// </summary>
    public Label S_Label => L_HSplitContainer.L_Right.L_MarginContainer.L_RightBg.L_Label;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.TextureRect"/>, 节点路径: TileSetEditorCombination.HSplitContainer.Right.MarginContainer.RightBg.ScrollContainer.CellButton.PreviewImage
    /// </summary>
    public PreviewImage S_PreviewImage => L_HSplitContainer.L_Right.L_MarginContainer.L_RightBg.L_ScrollContainer.L_CellButton.L_PreviewImage;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Label"/>, 节点路径: TileSetEditorCombination.HSplitContainer.Right.MarginContainer.RightBg.ScrollContainer.CellButton.CellName
    /// </summary>
    public CellName S_CellName => L_HSplitContainer.L_Right.L_MarginContainer.L_RightBg.L_ScrollContainer.L_CellButton.L_CellName;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.NinePatchRect"/>, 节点路径: TileSetEditorCombination.HSplitContainer.Right.MarginContainer.RightBg.ScrollContainer.CellButton.SelectTexture
    /// </summary>
    public SelectTexture S_SelectTexture => L_HSplitContainer.L_Right.L_MarginContainer.L_RightBg.L_ScrollContainer.L_CellButton.L_SelectTexture;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Button"/>, 节点路径: TileSetEditorCombination.HSplitContainer.Right.MarginContainer.RightBg.ScrollContainer.CellButton
    /// </summary>
    public CellButton S_CellButton => L_HSplitContainer.L_Right.L_MarginContainer.L_RightBg.L_ScrollContainer.L_CellButton;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.ScrollContainer"/>, 节点路径: TileSetEditorCombination.HSplitContainer.Right.MarginContainer.RightBg.ScrollContainer
    /// </summary>
    public ScrollContainer S_ScrollContainer => L_HSplitContainer.L_Right.L_MarginContainer.L_RightBg.L_ScrollContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="UI.TileSetEditorCombination.TileSelected"/>, 节点路径: TileSetEditorCombination.HSplitContainer.Right.MarginContainer.RightBg
    /// </summary>
    public RightBg S_RightBg => L_HSplitContainer.L_Right.L_MarginContainer.L_RightBg;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Panel"/>, 节点路径: TileSetEditorCombination.HSplitContainer.Right
    /// </summary>
    public Right S_Right => L_HSplitContainer.L_Right;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.HSplitContainer"/>, 节点路径: TileSetEditorCombination.HSplitContainer
    /// </summary>
    public HSplitContainer S_HSplitContainer => L_HSplitContainer;

}
