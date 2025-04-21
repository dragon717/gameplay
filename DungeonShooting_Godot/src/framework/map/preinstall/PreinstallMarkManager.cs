﻿
using System.Collections.Generic;
using Config;


public static class PreinstallMarkManager
{
    /// <summary>
    /// 随机武器
    /// </summary>
    public static readonly RandomActivityBase RandomWeapon = new RandomActivityBase()
    {
        Id = "$RandomGun",
        Name = "随机武器",
        Type = ActivityType.Other,
        Icon = ResourcePath.resource_sprite_ui_commonIcon_Dice_png,
        ShowInMapEditor = true
    };

    /// <summary>
    /// 随机敌人
    /// </summary>
    public static readonly RandomActivityBase RandomEnemy = new RandomActivityBase()
    {
        Id = "$RandomEnemy",
        Name = "随机敌人",
        Type = ActivityType.Other,
        Icon = ResourcePath.resource_sprite_ui_commonIcon_Dice_png,
        ShowInMapEditor = true
    };

    /// <summary>
    /// 随机道具
    /// </summary>
    public static readonly RandomActivityBase RandomProp = new RandomActivityBase()
    {
        Id = "$RandomProp",
        Name = "随机道具",
        Type = ActivityType.Other,
        Icon = ResourcePath.resource_sprite_ui_commonIcon_Dice_png,
        ShowInMapEditor = true
    };

    private static Dictionary<ActivityType, List<ExcelConfig.ActivityBase>> _cache = new Dictionary<ActivityType, List<ExcelConfig.ActivityBase>>();

    private static bool _init = false;
    
    public static void Init()
    {
        if (_init)return;
        _init = true;
        foreach (var activityBase in ExcelConfig.ActivityBase_List)
        {
            var type = (ActivityType)activityBase.Type;
            if (!_cache.TryGetValue(type, out var list))
            {
                list = new List<ExcelConfig.ActivityBase>();
                _cache.Add(type, list);
            }
            list.Add(activityBase);
        }
    }
    
    /// <summary>
    /// 根据id获取标记配置, 该函数会自动匹配随机标记
    /// </summary>
    public static ExcelConfig.ActivityBase GetMarkConfig(string id)
    {
        if (RandomWeapon.Id == id)
        {
            return RandomWeapon;
        }
        else if (RandomEnemy.Id == id)
        {
            return RandomEnemy;
        }
        else if (RandomProp.Id == id)
        {
            return RandomProp;
        }

        ExcelConfig.ActivityBase_Map.TryGetValue(id, out var activityBase);
        return activityBase;
    }

    public static List<ExcelConfig.ActivityBase> GetMarkConfigsByType(ActivityType type)
    {
        if (!_cache.TryGetValue(type, out var arr))
        {
            arr = new List<ExcelConfig.ActivityBase>();
            _cache.Add(type, arr);
        }
        return  arr;
    }

    /// <summary>
    /// 获取特殊标记名称
    /// </summary>
    public static string GetSpecialName(SpecialMarkType type)
    {
        if (type == SpecialMarkType.BirthPoint)
        {
            return "出生标记";
        }
        else if (type == SpecialMarkType.OutPoint)
        {
            return "出口标记";
        }
        else if (type == SpecialMarkType.ShopBoss)
        {
            return "商店老板标记";
        }
        else if (type == SpecialMarkType.Treasure)
        {
            return "奖励箱子标记";
        }

        return string.Empty;
    }
}