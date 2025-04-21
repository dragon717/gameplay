
/// <summary>
/// 主动道具使用条件基类
/// </summary>
public abstract class ConditionFragment : PropFragment
{
    /// <summary>
    /// 当前组件所挂载的游戏对象
    /// </summary>
    public new ActiveProp Master => (ActiveProp)base.Master;

    /// <summary>
    /// 当检测是否可以使用时调用
    /// </summary>
    public abstract bool OnCheckUse();

    public override void OnPickUpItem()
    {
    }

    public override void OnRemoveItem()
    {
    }
}