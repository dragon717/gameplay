
using System;
using System.Collections.Generic;
using System.Text.Json;
using Config;
using Godot;

/// <summary>
/// 主动使用道具
/// </summary>
[Tool]
public partial class ActiveProp : PropActivity, IPackageItem<Role>
{
    /// <summary>
    /// 配置数据
    /// </summary>
    public ExcelConfig.ActivePropBase Attribute { get; private set; }
    
    public int PackageIndex { get; set; }
    
    /// <summary>
    /// 道具可使用次数
    /// </summary>
    public int Count
    {
        get => _count;
        set
        {
            var temp = _count;
            _count = Mathf.Clamp(value, 0, _maxCount);
            if (temp != _count)
            {
                OnChangeCount();
            }
        }
    }

    private int _count = 1;

    /// <summary>
    /// 道具最大叠加用次数
    /// </summary>
    public int MaxCount
    {
        get => _maxCount;
        set
        {
            var temp = _maxCount;
            _maxCount = Mathf.Max(1, value);
            if (temp != _maxCount)
            {
                OnChangeMaxCount();
            }

            if (Count > _maxCount)
            {
                Count = _maxCount;
            }
        }
    }

    private int _maxCount = 1;
    
    /// <summary>
    /// 道具充能进度, 必须要充能完成才能使用, 值范围: 0 - 1
    /// </summary>
    public float ChargeProgress
    {
        get => _chargeProgress;
        set
        {
            var temp = _chargeProgress;
            _chargeProgress = Mathf.Clamp(value, 0, 1);
            if (temp != _chargeProgress)
            {
                OnChangeChargeProgress();
            }
        }
    }

    private float _chargeProgress = 1;
    
    /// <summary>
    /// 自动充能速度, 也就是每秒充能进度, 如果为0则表示不就行自动充能
    /// </summary>
    public float AutoChargeSpeed { get; set; }

    /// <summary>
    /// 是否正使用中
    /// </summary>
    public bool IsUsing => _durationTimer > 0;

    /// <summary>
    /// 道具使用时间进度 (0 - 1)
    /// </summary>
    public float UsingProgress => 1 - _durationTimer / Attribute.Duration;

    //冷却计时器
    private float _cooldownTimer = 0;
    //持续时间计时器
    private float _durationTimer = 0;
    
    //被动属性
    private readonly List<BuffFragment> _buffFragment = new List<BuffFragment>();
    //条件
    private readonly List<ConditionFragment> _conditionFragment = new List<ConditionFragment>();
    //效果
    private readonly List<EffectFragment> _effectFragment = new List<EffectFragment>();
    //充能
    private readonly List<ChargeFragment> _chargeFragment = new List<ChargeFragment>();

    public override void OnInit()
    {
        base.OnInit();
        var buffAttribute = GetActiveAttribute(ActivityBase.Id);
        Attribute = buffAttribute;
        
        //初始化buff属性
        if (buffAttribute.Buff != null)
        {
            foreach (var keyValuePair in buffAttribute.Buff)
            {
                var buffInfo = PropFragmentRegister.BuffFragmentInfos[keyValuePair.Key];
                var item = keyValuePair.Value;
                var buff = (BuffFragment)AddComponent(buffInfo.Type);
                try
                {
                    buff.InitParam(item);
                }
                catch (Exception e)
                {
                    Debug.LogError($"初始化道具'{ActivityBase.Id}'参数时发生异常: {e.Message}\n{e.StackTrace}");
                }
                _buffFragment.Add(buff);
            }
        }

        //初始化条件属性
        if (buffAttribute.Condition != null)
        {
            foreach (var keyValuePair in buffAttribute.Condition)
            {
                var buffInfo = PropFragmentRegister.ConditionFragmentInfos[keyValuePair.Key];
                var item = keyValuePair.Value;
                var buff = (ConditionFragment)AddComponent(buffInfo.Type);
                try
                {
                    buff.InitParam(item);
                }
                catch (Exception e)
                {
                    Debug.LogError($"初始化道具'{ActivityBase.Id}'参数时发生异常: {e.Message}\n{e.StackTrace}");
                }
                _conditionFragment.Add(buff);
            }
        }

        //初始化效果属性
        if (buffAttribute.Effect != null)
        {
            foreach (var keyValuePair in buffAttribute.Effect)
            {
                var buffInfo = PropFragmentRegister.EffectFragmentInfos[keyValuePair.Key];
                var item = keyValuePair.Value;
                var buff = (EffectFragment)AddComponent(buffInfo.Type);
                try
                {
                    buff.InitParam(item);
                }
                catch (Exception e)
                {
                    Debug.LogError($"初始化道具'{ActivityBase.Id}'参数时发生异常: {e.Message}\n{e.StackTrace}");
                }
                _effectFragment.Add(buff);
            }
        }

        //初始化道具冷却属性数据
        if (!buffAttribute.IsConsumables && buffAttribute.Charge != null)
        {
            foreach (var keyValuePair in buffAttribute.Charge)
            {
                var buffInfo = PropFragmentRegister.ChargeFragmentInfos[keyValuePair.Key];
                var item = keyValuePair.Value;
                var buff = (ChargeFragment)AddComponent(buffInfo.Type);
                try
                {
                    buff.InitParam(item);
                }
                catch (Exception e)
                {
                    Debug.LogError($"初始化道具'{ActivityBase.Id}'参数时发生异常: {e.Message}\n{e.StackTrace}");
                }
                _chargeFragment.Add(buff);
            }
        }
        
        //显示纹理
        if (!string.IsNullOrEmpty(ActivityBase.Icon))
        {
            SetDefaultTexture(ResourceManager.LoadTexture2D(ActivityBase.Icon));
        }

        MaxCount = (int)Attribute.MaxCount;
    }

    /// <summary>
    /// 当检测是否可以使用时调用
    /// </summary>
    public virtual bool OnCheckUse()
    {
        foreach (var fragment in _conditionFragment)
        {
            if (!fragment.OnCheckUse()) return false;
        }
        
        foreach (var fragment in _effectFragment)
        {
            if (!fragment.OnCheckUse()) return false;
        }

        return true;
    }

    /// <summary>
    /// 当道具被使用时调用
    /// </summary>
    protected virtual void OnUse()
    {
        foreach (var fragment in _effectFragment)
        {
            fragment.OnUse();
        }

        foreach (var fragment in _chargeFragment)
        {
            fragment.OnUse();
        }
        
    }

    /// <summary>
    /// 道具使用持续时间完成时调用
    /// </summary>
    protected virtual void OnUsingFinish()
    {
    }

    /// <summary>
    /// 道具数量改变时调用
    /// </summary>
    protected virtual void OnChangeCount()
    {
    }

    /// <summary>
    /// 道具最大数量改变时调用
    /// </summary>
    protected virtual void OnChangeMaxCount()
    {
    }

    /// <summary>
    /// 道具充能进度改变时调用
    /// </summary>
    protected virtual void OnChangeChargeProgress()
    {
    }

    /// <summary>
    /// 冷却完成时调用
    /// </summary>
    protected virtual void OnCooldownFinish()
    {
    }

    protected override void Process(float delta)
    {
        if (CheckAutoDestroy())
        {
            return;
        }

        //持续时间
        if (_durationTimer > 0)
        {
            _durationTimer -= delta;
            
            //持续时间完成
            if (_durationTimer <= 0)
            {
                _durationTimer = 0;
                //冷却计时器
                _cooldownTimer = Attribute.CooldownTime;
                UsingFinish();
            }
        }
        //冷却
        else if (_cooldownTimer > 0)
        {
            _cooldownTimer -= delta;

            //冷却完成
            if (_cooldownTimer <= 0)
            {
                _cooldownTimer = 0;
                OnCooldownFinish();
            }
        }
        
        //自动充能
        if (AutoChargeSpeed > 0 && ChargeProgress < 1)
        {
            ChargeProgress += AutoChargeSpeed * delta;
        }
    }
    
    //检测是否达到自动销毁的条件
    private bool CheckAutoDestroy()
    {
        if (Count == 0 && Attribute.IsConsumables) //用光了, 自动销毁
        {
            if (Master != null)
            {
                Master.ActivePropsPack.RemoveItem(this);
            }
            Destroy();
            return true;
        }

        return false;
    }
    
    /// <summary>
    /// 检测是否可以使用当前道具
    /// </summary>
    public bool CheckUse()
    {
        return ChargeProgress >= 1 && _cooldownTimer <= 0 && Count > 0 && OnCheckUse();
    }
    
    /// <summary>
    /// 触发使用道具
    /// </summary>
    public void Use()
    {
        if (Master == null || IsUsing)
        {
            return;
        }
        if (CheckUse()) //可以使用道具
        {
            OnUse();
            if (Attribute.IsConsumables)
            {
                Count -= 1;
            }

            if (Attribute.Duration > 0) //持续时间
            {
                _durationTimer = Attribute.Duration;
            }
            else
            {
                //冷却计时器
                _cooldownTimer = Attribute.CooldownTime;
                UsingFinish();
            }
        }
    }

    /// <summary>
    /// 获取冷却进度 0 - 1
    /// </summary>
    public float GetCooldownProgress()
    {
        if (_cooldownTimer <= 0)
        {
            return 1;
        }

        return (Attribute.CooldownTime - _cooldownTimer) / Attribute.CooldownTime;
    }

    public override void Interactive(ActivityObject master)
    {
        if (master is Player player)
        {
            if (player.ActivePropsPack.Capacity == 0)
            {
                //容量为0
                return;
            }
            var item = player.ActivePropsPack.GetItemById(ActivityBase.Id);
            if (item == null) //没有同类型物体
            {
                if (!player.ActivePropsPack.HasVacancy()) //没有空位置, 扔掉当前道具
                {
                    player.ThrowActiveProp(player.ActivePropsPack.ActiveIndex);
                }
                //替换手中的道具
                if (player.PickUpActiveProp(this))
                {
                    Pickup();
                }
            }
            else
            {
                //处理同类型道具
                if (item.Count < item.MaxCount) //允许叠加
                {
                    if (item.Count + Count > item.MaxCount)
                    {
                        Count -= item.MaxCount - item.Count;
                        item.Count = item.MaxCount;
                    }
                    else
                    {
                        item.Count += Count;
                        Count = 0;
                    }
                    Destroy();
                }
            }
        }
    }

    public override CheckInteractiveResult CheckInteractive(ActivityObject master)
    {
        if (master is Player player)
        {
            if (player.ActivePropsPack.Capacity == 0)
            {
                //容量为0
                return new CheckInteractiveResult(this);
            }
            //查找相同类型的道具
            var item = player.ActivePropsPack.GetItemById(ActivityBase.Id);
            if (item == null) //没有同类型物体
            {
                if (player.ActivePropsPack.HasVacancy()) //还有空位, 拾起道具
                {
                    return new CheckInteractiveResult(this, true, CheckInteractiveResult.InteractiveType.PickUp);
                }

                //替换手中的道具
                return new CheckInteractiveResult(this, true, CheckInteractiveResult.InteractiveType.Replace);
            }

            //处理同类型道具
            if (item.Count < item.MaxCount) //允许叠加
            {
                return new CheckInteractiveResult(this, true, CheckInteractiveResult.InteractiveType.Bullet);
            }

            //该道具不能拾起
            return new CheckInteractiveResult(this);
        }

        return new CheckInteractiveResult(this);
    }

    public override void OnPickUpItem()
    {
        foreach (var buffFragment in _buffFragment)
        {
            buffFragment.OnPickUpItem();
        }

        foreach (var conditionFragment in _conditionFragment)
        {
            conditionFragment.OnPickUpItem();
        }
        
        foreach (var effectFragment in _effectFragment)
        {
            effectFragment.OnPickUpItem();
        }
        
        foreach (var chargeFragment in _chargeFragment)
        {
            chargeFragment.OnPickUpItem();
        }
    }

    public override void OnRemoveItem()
    {
        foreach (var buffFragment in _buffFragment)
        {
            buffFragment.OnRemoveItem();
        }

        foreach (var conditionFragment in _conditionFragment)
        {
            conditionFragment.OnRemoveItem();
        }
        
        foreach (var effectFragment in _effectFragment)
        {
            effectFragment.OnRemoveItem();
        }
        
        foreach (var chargeFragment in _chargeFragment)
        {
            chargeFragment.OnRemoveItem();
        }
    }

    public virtual void OnActiveItem()
    {
    }

    public virtual void OnConcealItem()
    {
    }

    public virtual void OnOverflowItem()
    {
        Master.ThrowActiveProp(PackageIndex);
    }
    
    /// <summary>
    /// 添加被动属性
    /// </summary>
    public void AddBuffFragment<T>(JsonElement[] arg) where T : BuffFragment, new()
    {
        var fragment = AddComponent<T>();
        _buffFragment.Add(fragment);
        try
        {
            fragment.InitParam(arg);
        }
        catch (Exception e)
        {
            Debug.LogError($"初始化道具'{ActivityBase.Id}'参数时发生异常: {e.Message}\n{e.StackTrace}");
        }
        if (Master != null)
        {
            fragment.OnPickUpItem();
        }
    }

    //持续时间完成
    private void UsingFinish()
    {
        OnUsingFinish();
        
        foreach (var effectFragment in _effectFragment)
        {
            effectFragment.OnUsingFinish();
        }
        
        foreach (var chargeFragment in _chargeFragment)
        {
            chargeFragment.OnUsingFinish();
        }
    }
    
    
    private static bool _init = false;
    private static Dictionary<string, ExcelConfig.ActivePropBase> _activeAttributeMap =
        new Dictionary<string, ExcelConfig.ActivePropBase>();

    /// <summary>
    /// 初始化主动道具属性数据
    /// </summary>
    public static void InitActiveAttribute()
    {
        if (_init)
        {
            return;
        }

        _init = true;
        foreach (var buffAttr in ExcelConfig.ActivePropBase_List)
        {
            if (buffAttr.Activity != null)
            {
                if (!_activeAttributeMap.TryAdd(buffAttr.Activity.Id, buffAttr))
                {
                    Debug.LogError("发现重复注册的主动道具属性: " + buffAttr.Id);
                }
            }
        }
    }
    
    /// <summary>
    /// 根据 ActivityBase.Id 获取对应主动道具的属性数据
    /// </summary>
    public static ExcelConfig.ActivePropBase GetActiveAttribute(string itemId)
    {
        if (itemId == null)
        {
            return null;
        }
        if (_activeAttributeMap.TryGetValue(itemId, out var attr))
        {
            return attr;
        }

        throw new Exception($"主动道具'{itemId}'没有在 ActivePropBase 表中配置属性数据!");
    }
}