
using System.Collections.Generic;
using System.Linq;
using Godot;

/// <summary>
/// 房间图块配置信息
/// </summary>
public class AutoTileConfig
{
    public TileCellData Floor;
    public TileCellData TopMask;
    public TileCellData Wall_Bottom;
    public TileCellData Wall_Left;
    public TileCellData Wall_Right;
    public TileCellData Wall_Top;
    public TileCellData Wall_Out_LB;
    public TileCellData Wall_Out_LT;
    public TileCellData Wall_Out_RB;
    public TileCellData Wall_Out_RT;
    public TileCellData Wall_In_LT;
    public TileCellData Wall_In_LB;
    public TileCellData Wall_In_RT;
    public TileCellData Wall_In_RB;
    
    public TileCellData Wall_Vertical_LeftTop;
    public TileCellData Wall_Vertical_CenterTop;
    public TileCellData Wall_Vertical_RightTop;
    public TileCellData Wall_Vertical_SingleTop;
    
    public TileCellData Wall_Vertical_LeftBottom;
    public TileCellData Wall_Vertical_CenterBottom;
    public TileCellData Wall_Vertical_RightBottom;
    public TileCellData Wall_Vertical_SingleBottom;
    
    //----------------------------- 所有自动图块数据 -----------------------------
    //----------------------------- 命名规则: Auto_ + LT + T + RT + _ + L + C + R + _ + LB + B + RB
    //第一列
    public TileCellData Auto_000_010_010;
    public TileCellData Auto_010_010_010;
    public TileCellData Auto_010_010_000;
    public TileCellData Auto_000_010_000;
    //第二列
    public TileCellData Auto_000_011_010;
    public TileCellData Auto_010_011_010;
    public TileCellData Auto_010_011_000;
    public TileCellData Auto_000_011_000;
    //第三列
    public TileCellData Auto_000_111_010;
    public TileCellData Auto_010_111_010;
    public TileCellData Auto_010_111_000;
    public TileCellData Auto_000_111_000;
    //第四列
    public TileCellData Auto_000_110_010;
    public TileCellData Auto_010_110_010;
    public TileCellData Auto_010_110_000;
    public TileCellData Auto_000_110_000;
    //第五列
    public TileCellData Auto_110_111_010;
    public TileCellData Auto_010_011_011;
    public TileCellData Auto_011_011_010;
    public TileCellData Auto_010_111_110;
    //第六列
    public TileCellData Auto_000_111_011;
    public TileCellData Auto_011_111_111;
    public TileCellData Auto_111_111_011;
    public TileCellData Auto_011_111_000;
    //第七列
    public TileCellData Auto_000_111_110;
    public TileCellData Auto_110_111_111;
    public TileCellData Auto_111_111_110;
    public TileCellData Auto_110_111_000;
    //第八列
    public TileCellData Auto_011_111_010;
    public TileCellData Auto_010_110_110;
    public TileCellData Auto_110_110_010;
    public TileCellData Auto_010_111_011;
    //第九列
    public TileCellData Auto_000_011_011;
    public TileCellData Auto_011_011_011;
    public TileCellData Auto_011_111_011;
    public TileCellData Auto_011_011_000;
    //第十列
    public TileCellData Auto_010_111_111;
    public TileCellData Auto_110_111_011;
    public TileCellData Auto_111_111_111;
    public TileCellData Auto_111_111_000;
    //第十一列
    public TileCellData Auto_000_111_111;
    public TileCellData Auto_011_111_110;
    public TileCellData Auto_111_111_010;
    //第十二列
    public TileCellData Auto_000_110_110;
    public TileCellData Auto_110_111_110;
    public TileCellData Auto_110_110_110;
    public TileCellData Auto_110_110_000;
    
    //------------------------------------------------------------------------- 

    /// <summary>
    /// 所属资源Id
    /// </summary>
    public int SourceId { get; private set; }
    
    /// <summary>
    /// 原地形配置数据
    /// </summary>
    public TileSetTerrainInfo TerrainInfo { get; private set; }
    
    private Dictionary<Vector2I, TileCellData> _mapping = new Dictionary<Vector2I, TileCellData>();

    public AutoTileConfig(int sourceId, TileSetTerrainInfo terrainInfo)
    {
        SourceId = sourceId;
        TerrainInfo = terrainInfo;
        if (terrainInfo.T != null)
        {
            foreach (var keyValuePair in terrainInfo.T)
            {
                HandlerTileData(keyValuePair.Key, sourceId, terrainInfo.GetPosition(keyValuePair.Value));
            }
        }

        if (terrainInfo.M != null)
        {
            int[] data;
            if (terrainInfo.M.TryGetValue(0, out data))
            {
                Wall_Vertical_SingleTop = new TileCellData(sourceId, terrainInfo.GetPosition(data), 0, TileSetTerrainInfo.MiddleLayerType, MapLayer.AutoMiddleLayer);
            }
            if (terrainInfo.M.TryGetValue(1, out data))
            {
                Wall_Vertical_LeftTop = new TileCellData(sourceId, terrainInfo.GetPosition(data), 1, TileSetTerrainInfo.MiddleLayerType, MapLayer.AutoMiddleLayer);
            }
            if (terrainInfo.M.TryGetValue(2, out data))
            {
                Wall_Vertical_CenterTop = new TileCellData(sourceId, terrainInfo.GetPosition(data), 2, TileSetTerrainInfo.MiddleLayerType, MapLayer.AutoMiddleLayer);
            }
            if (terrainInfo.M.TryGetValue(3, out data))
            {
                Wall_Vertical_RightTop = new TileCellData(sourceId, terrainInfo.GetPosition(data), 3, TileSetTerrainInfo.MiddleLayerType, MapLayer.AutoMiddleLayer);
            }
            
            if (terrainInfo.M.TryGetValue(4, out data))
            {
                Wall_Vertical_SingleBottom= new TileCellData(sourceId, terrainInfo.GetPosition(data), 4, TileSetTerrainInfo.MiddleLayerType, MapLayer.AutoMiddleLayer);
            }
            if (terrainInfo.M.TryGetValue(5, out data))
            {
                Wall_Vertical_LeftBottom = new TileCellData(sourceId, terrainInfo.GetPosition(data), 5, TileSetTerrainInfo.MiddleLayerType, MapLayer.AutoMiddleLayer);
            }
            if (terrainInfo.M.TryGetValue(6, out data))
            {
                Wall_Vertical_CenterBottom = new TileCellData(sourceId, terrainInfo.GetPosition(data), 6, TileSetTerrainInfo.MiddleLayerType, MapLayer.AutoMiddleLayer);
            }
            if (terrainInfo.M.TryGetValue(7, out data))
            {
                Wall_Vertical_RightBottom = new TileCellData(sourceId, terrainInfo.GetPosition(data), 7, TileSetTerrainInfo.MiddleLayerType, MapLayer.AutoMiddleLayer);
            }
        }
        
        if (terrainInfo.F != null)
        {
            if (terrainInfo.F.TryGetValue(0, out var data))
            {
                Floor = new TileCellData(sourceId, terrainInfo.GetPosition(data), 0, TileSetTerrainInfo.FloorLayerType, MapLayer.AutoFloorLayer);
            }
        }
        
        TopMask = Auto_111_111_111;
        Wall_Bottom = Auto_000_111_111;
        Wall_Left = Auto_110_110_110;
        Wall_Right = Auto_011_011_011;
        Wall_Top = Auto_111_111_000;

        Wall_Out_LB = Auto_011_011_000;
        Wall_Out_LT = Auto_000_011_011;
        Wall_Out_RB = Auto_110_110_000;
        Wall_Out_RT = Auto_000_110_110;

        Wall_In_LT = Auto_111_111_110;
        Wall_In_LB = Auto_110_111_111;
        Wall_In_RT = Auto_111_111_011;
        Wall_In_RB = Auto_011_111_111;

        HandlerMapping();
        HandlerOtherCellMapping();
    }

    public int GetLayer(Vector2I atlasCoords)
    {
        if (_mapping.TryGetValue(atlasCoords, out var tile))
        {
            return tile.DefaultLayer;
        }

        return MapLayer.AutoFloorLayer;
    }

    public TileCellData GetCellData(Vector2I atlasCoords)
    {
        _mapping.TryGetValue(atlasCoords, out var tile);
        return tile;
    }

    private void HandlerTileData(uint peeringValue, int sourceId, Vector2I pos)
    {
        switch (peeringValue)
        {
            //第一列
            case TerrainPeering.Center | TerrainPeering.Bottom:
                Auto_000_010_010 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            case TerrainPeering.Top | TerrainPeering.Center | TerrainPeering.Bottom:
                Auto_010_010_010 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            case TerrainPeering.Top | TerrainPeering.Center:
                Auto_010_010_000 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            case TerrainPeering.Center:
                Auto_000_010_000 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            //第二列
            case TerrainPeering.Center | TerrainPeering.Right | TerrainPeering.Bottom:
                Auto_000_011_010 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            case TerrainPeering.Top | TerrainPeering.Center | TerrainPeering.Right | TerrainPeering.Bottom:
                Auto_010_011_010 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            case TerrainPeering.Top | TerrainPeering.Center | TerrainPeering.Right:
                Auto_010_011_000 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            case TerrainPeering.Center | TerrainPeering.Right:
                Auto_000_011_000 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            //第三列
            case TerrainPeering.Left | TerrainPeering.Center | TerrainPeering.Right | TerrainPeering.Bottom:
                Auto_000_111_010 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            case TerrainPeering.Top | TerrainPeering.Left | TerrainPeering.Center | TerrainPeering.Right |
                 TerrainPeering.Bottom:
                Auto_010_111_010 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            case TerrainPeering.Top | TerrainPeering.Left | TerrainPeering.Center | TerrainPeering.Right:
                Auto_010_111_000 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            case TerrainPeering.Left | TerrainPeering.Center | TerrainPeering.Right:
                Auto_000_111_000 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            //第四列
            case TerrainPeering.Left | TerrainPeering.Center | TerrainPeering.Bottom:
                Auto_000_110_010 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            case TerrainPeering.Top | TerrainPeering.Left | TerrainPeering.Center | TerrainPeering.Bottom:
                Auto_010_110_010 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            case TerrainPeering.Top | TerrainPeering.Left | TerrainPeering.Center:
                Auto_010_110_000 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            case TerrainPeering.Left | TerrainPeering.Center:
                Auto_000_110_000 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            //第五列
            case TerrainPeering.LeftTop | TerrainPeering.Top | TerrainPeering.Left | TerrainPeering.Center |
                 TerrainPeering.Right | TerrainPeering.Bottom:
                Auto_110_111_010 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            case TerrainPeering.Top | TerrainPeering.Center | TerrainPeering.Right | TerrainPeering.Bottom |
                 TerrainPeering.RightBottom:
                Auto_010_011_011 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            case TerrainPeering.Top | TerrainPeering.RightTop | TerrainPeering.Center | TerrainPeering.Right |
                 TerrainPeering.Bottom:
                Auto_011_011_010 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            case TerrainPeering.Top | TerrainPeering.Left | TerrainPeering.Center | TerrainPeering.Right |
                 TerrainPeering.LeftBottom | TerrainPeering.Bottom:
                Auto_010_111_110 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            //第六列
            case TerrainPeering.Left | TerrainPeering.Center | TerrainPeering.Right | TerrainPeering.Bottom |
                 TerrainPeering.RightBottom:
                Auto_000_111_011 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            case TerrainPeering.Top | TerrainPeering.RightTop | TerrainPeering.Left | TerrainPeering.Center |
                 TerrainPeering.Right | TerrainPeering.LeftBottom | TerrainPeering.Bottom | TerrainPeering.RightBottom:
                Auto_011_111_111 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            case TerrainPeering.LeftTop | TerrainPeering.Top | TerrainPeering.RightTop | TerrainPeering.Left |
                 TerrainPeering.Center | TerrainPeering.Right | TerrainPeering.Bottom | TerrainPeering.RightBottom:
                Auto_111_111_011 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            case TerrainPeering.Top | TerrainPeering.RightTop | TerrainPeering.Left | TerrainPeering.Center |
                 TerrainPeering.Right:
                Auto_011_111_000 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            //第七列
            case TerrainPeering.Left | TerrainPeering.Center | TerrainPeering.Right | TerrainPeering.LeftBottom |
                 TerrainPeering.Bottom:
                Auto_000_111_110 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            case TerrainPeering.LeftTop | TerrainPeering.Top | TerrainPeering.Left | TerrainPeering.Center |
                 TerrainPeering.Right | TerrainPeering.LeftBottom | TerrainPeering.Bottom | TerrainPeering.RightBottom:
                Auto_110_111_111 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            case TerrainPeering.LeftTop | TerrainPeering.Top | TerrainPeering.RightTop | TerrainPeering.Left |
                 TerrainPeering.Center | TerrainPeering.Right | TerrainPeering.LeftBottom | TerrainPeering.Bottom:
                Auto_111_111_110 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            case TerrainPeering.LeftTop | TerrainPeering.Top | TerrainPeering.Left | TerrainPeering.Center |
                 TerrainPeering.Right:
                Auto_110_111_000 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            //第八列
            case TerrainPeering.Top | TerrainPeering.RightTop | TerrainPeering.Left | TerrainPeering.Center |
                 TerrainPeering.Right | TerrainPeering.Bottom:
                Auto_011_111_010 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            case TerrainPeering.Top | TerrainPeering.Left | TerrainPeering.Center | TerrainPeering.LeftBottom |
                 TerrainPeering.Bottom:
                Auto_010_110_110 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            case TerrainPeering.LeftTop | TerrainPeering.Top | TerrainPeering.Left | TerrainPeering.Center |
                 TerrainPeering.Bottom:
                Auto_110_110_010 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            case TerrainPeering.Top | TerrainPeering.Left | TerrainPeering.Center | TerrainPeering.Right |
                 TerrainPeering.Bottom | TerrainPeering.RightBottom:
                Auto_010_111_011 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            //第九列
            case TerrainPeering.Center | TerrainPeering.Right | TerrainPeering.Bottom | TerrainPeering.RightBottom:
                Auto_000_011_011 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            case TerrainPeering.Top | TerrainPeering.RightTop | TerrainPeering.Center | TerrainPeering.Right |
                 TerrainPeering.Bottom | TerrainPeering.RightBottom:
                Auto_011_011_011 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            case TerrainPeering.Top | TerrainPeering.RightTop | TerrainPeering.Left | TerrainPeering.Center |
                 TerrainPeering.Right | TerrainPeering.Bottom | TerrainPeering.RightBottom:
                Auto_011_111_011 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            case TerrainPeering.Top | TerrainPeering.RightTop | TerrainPeering.Center | TerrainPeering.Right:
                Auto_011_011_000 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            //第十列
            case TerrainPeering.Top | TerrainPeering.Left | TerrainPeering.Center | TerrainPeering.Right |
                 TerrainPeering.LeftBottom | TerrainPeering.Bottom | TerrainPeering.RightBottom:
                Auto_010_111_111 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            case TerrainPeering.LeftTop | TerrainPeering.Top | TerrainPeering.Left | TerrainPeering.Center |
                 TerrainPeering.Right | TerrainPeering.Bottom | TerrainPeering.RightBottom:
                Auto_110_111_011 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            case TerrainPeering.LeftTop | TerrainPeering.Top | TerrainPeering.RightTop | TerrainPeering.Left |
                 TerrainPeering.Center | TerrainPeering.Right | TerrainPeering.LeftBottom | TerrainPeering.Bottom |
                 TerrainPeering.RightBottom:
                Auto_111_111_111 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            case TerrainPeering.LeftTop | TerrainPeering.Top | TerrainPeering.RightTop | TerrainPeering.Left |
                 TerrainPeering.Center | TerrainPeering.Right:
                Auto_111_111_000 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            //第十一列
            case TerrainPeering.Left | TerrainPeering.Center | TerrainPeering.Right | TerrainPeering.LeftBottom |
                 TerrainPeering.Bottom | TerrainPeering.RightBottom:
                Auto_000_111_111 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            case TerrainPeering.Top | TerrainPeering.RightTop | TerrainPeering.Left | TerrainPeering.Center |
                 TerrainPeering.Right | TerrainPeering.LeftBottom | TerrainPeering.Bottom:
                Auto_011_111_110 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            case TerrainPeering.LeftTop | TerrainPeering.Top | TerrainPeering.RightTop | TerrainPeering.Left |
                 TerrainPeering.Center | TerrainPeering.Right | TerrainPeering.Bottom:
                Auto_111_111_010 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            //第十二列
            case TerrainPeering.Left | TerrainPeering.Center | TerrainPeering.LeftBottom | TerrainPeering.Bottom:
                Auto_000_110_110 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            case TerrainPeering.LeftTop | TerrainPeering.Top | TerrainPeering.Left | TerrainPeering.Center |
                 TerrainPeering.Right | TerrainPeering.LeftBottom | TerrainPeering.Bottom:
                Auto_110_111_110 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            case TerrainPeering.LeftTop | TerrainPeering.Top | TerrainPeering.Left | TerrainPeering.Center |
                 TerrainPeering.LeftBottom | TerrainPeering.Bottom:
                Auto_110_110_110 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;
            case TerrainPeering.LeftTop | TerrainPeering.Top | TerrainPeering.Left | TerrainPeering.Center:
                Auto_110_110_000 = new TileCellData(sourceId, pos, peeringValue, TileSetTerrainInfo.TerrainLayerType, MapLayer.AutoTopLayer);
                break;

            default:
                Debug.LogError("未知PeeringValue: " + peeringValue);
                break;
        }
    }


    private void HandlerMapping()
    {
        //第一列
        _mapping.Add(Auto_000_010_010.AutoTileCoords, Auto_000_010_010);
        _mapping.Add(Auto_010_010_010.AutoTileCoords, Auto_010_010_010);
        _mapping.Add(Auto_010_010_000.AutoTileCoords, Auto_010_010_000);
        _mapping.Add(Auto_000_010_000.AutoTileCoords, Auto_000_010_000);
        //第二列
        _mapping.Add(Auto_000_011_010.AutoTileCoords, Auto_000_011_010);
        _mapping.Add(Auto_010_011_010.AutoTileCoords, Auto_010_011_010);
        _mapping.Add(Auto_010_011_000.AutoTileCoords, Auto_010_011_000);
        _mapping.Add(Auto_000_011_000.AutoTileCoords, Auto_000_011_000);
        //第三列
        _mapping.Add(Auto_000_111_010.AutoTileCoords, Auto_000_111_010);
        _mapping.Add(Auto_010_111_010.AutoTileCoords, Auto_010_111_010);
        _mapping.Add(Auto_010_111_000.AutoTileCoords, Auto_010_111_000);
        _mapping.Add(Auto_000_111_000.AutoTileCoords, Auto_000_111_000);
        //第四列
        _mapping.Add(Auto_000_110_010.AutoTileCoords, Auto_000_110_010);
        _mapping.Add(Auto_010_110_010.AutoTileCoords, Auto_010_110_010);
        _mapping.Add(Auto_010_110_000.AutoTileCoords, Auto_010_110_000);
        _mapping.Add(Auto_000_110_000.AutoTileCoords, Auto_000_110_000);
        //第五列
        _mapping.Add(Auto_110_111_010.AutoTileCoords, Auto_110_111_010);
        _mapping.Add(Auto_010_011_011.AutoTileCoords, Auto_010_011_011);
        _mapping.Add(Auto_011_011_010.AutoTileCoords, Auto_011_011_010);
        _mapping.Add(Auto_010_111_110.AutoTileCoords, Auto_010_111_110);
        //第六列
        _mapping.Add(Auto_000_111_011.AutoTileCoords, Auto_000_111_011);
        _mapping.Add(Auto_011_111_111.AutoTileCoords, Auto_011_111_111);
        _mapping.Add(Auto_111_111_011.AutoTileCoords, Auto_111_111_011);
        _mapping.Add(Auto_011_111_000.AutoTileCoords, Auto_011_111_000);
        //第七列
        _mapping.Add(Auto_000_111_110.AutoTileCoords, Auto_000_111_110);
        _mapping.Add(Auto_110_111_111.AutoTileCoords, Auto_110_111_111);
        _mapping.Add(Auto_111_111_110.AutoTileCoords, Auto_111_111_110);
        _mapping.Add(Auto_110_111_000.AutoTileCoords, Auto_110_111_000);
        //第八列
        _mapping.Add(Auto_011_111_010.AutoTileCoords, Auto_011_111_010);
        _mapping.Add(Auto_010_110_110.AutoTileCoords, Auto_010_110_110);
        _mapping.Add(Auto_110_110_010.AutoTileCoords, Auto_110_110_010);
        _mapping.Add(Auto_010_111_011.AutoTileCoords, Auto_010_111_011);
        //第九列
        _mapping.Add(Auto_000_011_011.AutoTileCoords, Auto_000_011_011);
        _mapping.Add(Auto_011_011_011.AutoTileCoords, Auto_011_011_011);
        _mapping.Add(Auto_011_111_011.AutoTileCoords, Auto_011_111_011);
        _mapping.Add(Auto_011_011_000.AutoTileCoords, Auto_011_011_000);
        //第十列
        _mapping.Add(Auto_010_111_111.AutoTileCoords, Auto_010_111_111);
        _mapping.Add(Auto_110_111_011.AutoTileCoords, Auto_110_111_011);
        _mapping.Add(Auto_111_111_111.AutoTileCoords, Auto_111_111_111);
        _mapping.Add(Auto_111_111_000.AutoTileCoords, Auto_111_111_000);
        //第十一列
        _mapping.Add(Auto_000_111_111.AutoTileCoords, Auto_000_111_111);
        _mapping.Add(Auto_011_111_110.AutoTileCoords, Auto_011_111_110);
        _mapping.Add(Auto_111_111_010.AutoTileCoords, Auto_111_111_010);
        //第十二列
        _mapping.Add(Auto_000_110_110.AutoTileCoords, Auto_000_110_110);
        _mapping.Add(Auto_110_111_110.AutoTileCoords, Auto_110_111_110);
        _mapping.Add(Auto_110_110_110.AutoTileCoords, Auto_110_110_110);
        _mapping.Add(Auto_110_110_000.AutoTileCoords, Auto_110_110_000);
    }

    private void HandlerOtherCellMapping()
    {
        _mapping.Add(Floor.AutoTileCoords, Floor);
        _mapping.Add(Wall_Vertical_LeftTop.AutoTileCoords, Wall_Vertical_LeftTop);
        _mapping.Add(Wall_Vertical_RightTop.AutoTileCoords, Wall_Vertical_RightTop);
        _mapping.Add(Wall_Vertical_CenterTop.AutoTileCoords, Wall_Vertical_CenterTop);
        _mapping.Add(Wall_Vertical_SingleTop.AutoTileCoords, Wall_Vertical_SingleTop);
        _mapping.Add(Wall_Vertical_LeftBottom.AutoTileCoords, Wall_Vertical_LeftBottom);
        _mapping.Add(Wall_Vertical_CenterBottom.AutoTileCoords, Wall_Vertical_CenterBottom);
        _mapping.Add(Wall_Vertical_RightBottom.AutoTileCoords, Wall_Vertical_RightBottom);
        _mapping.Add(Wall_Vertical_SingleBottom.AutoTileCoords, Wall_Vertical_SingleBottom);
    }
}