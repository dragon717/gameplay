﻿
using System.Collections.Generic;
using System.Text.Json.Serialization;

/// <summary>
/// 房间配置数据
/// </summary>
public class DungeonRoomInfo
{
    /// <summary>
    /// 房间位置, 在tile坐标系中的位置, 单位: 格
    /// </summary>
    [JsonInclude]
    public SerializeVector2 Position;
    
    /// <summary>
    /// 房间大小, 在tile坐标系中占用的格子, 单位: 格
    /// </summary>
    [JsonInclude]
    public SerializeVector2 Size;
    
    /// <summary>
    /// 房间连通门
    /// </summary>
    [JsonInclude]
    public List<DoorAreaInfo> DoorAreaInfos;

    /// <summary>
    /// 当前房间所属分组的名称
    /// </summary>
    [JsonInclude]
    public string GroupName;
    
    /// <summary>
    /// 房间类型
    /// </summary>
    [JsonInclude]
    public DungeonRoomType RoomType = DungeonRoomType.Battle;

    /// <summary>
    /// 房间名称
    /// </summary>
    [JsonInclude]
    public string RoomName;
    
    /// <summary>
    /// 房间权重, 值越大, 生成地牢是越容易出现该房间
    /// </summary>
    [JsonInclude]
    public int Weight = ResourceManager.DefaultWeight;

    /// <summary>
    /// 房间备注
    /// </summary>
    [JsonInclude]
    public string Remark;

    private List<DoorAreaInfo> _completionDoorArea;

    /// <summary>
    /// 获取门区域配置数据, 如果该函数会自动填充未配置的数据
    /// </summary>
    public List<DoorAreaInfo> GetCompletionDoorArea()
    {
        if (_completionDoorArea == null)
        {
            //需要处理 DoorAreaInfos 长度为 0 的房间, 并为其配置默认值
            _completionDoorArea = new List<DoorAreaInfo>(DoorAreaInfos);
            if (_completionDoorArea.Count == 0)
            {
                _completionDoorArea.Add(new DoorAreaInfo(DoorDirection.N, 0, ((int)Size.X - 4) * GameConfig.TileCellSize));
                _completionDoorArea.Add(new DoorAreaInfo(DoorDirection.S, 0, ((int)Size.X - 4) * GameConfig.TileCellSize));
                _completionDoorArea.Add(new DoorAreaInfo(DoorDirection.W, 0, ((int)Size.Y - 5) * GameConfig.TileCellSize));
                _completionDoorArea.Add(new DoorAreaInfo(DoorDirection.E, 0, ((int)Size.Y - 5) * GameConfig.TileCellSize));
            }
        }
        
        return _completionDoorArea;
    }

    /// <summary>
    /// 清除门区域配置数据, 再次调用 GetCompletionDoorArea() 会重新计算 DoorAreaInfo 数据
    /// </summary>
    public void ClearCompletionDoorArea()
    {
        if (_completionDoorArea != null)
        {
            _completionDoorArea.Clear();
            _completionDoorArea = null;
        }
    }

    public void InitData()
    {
        Size = new SerializeVector2();
        Position = new SerializeVector2();
        DoorAreaInfos = new List<DoorAreaInfo>();
    }
}