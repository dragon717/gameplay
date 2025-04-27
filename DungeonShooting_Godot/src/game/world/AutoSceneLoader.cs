using Godot;
using Godot.Collections;
using System;
using System.Linq;
using UI.Main;

public partial class AutoSceneLoader : Node
{
    public static void Init()
    {
        // 设置主界面
        var args = OS.GetCmdlineArgs();
        // 查找类似 --scene=xxx.tscn 的参数
        var sceneArg = args.FirstOrDefault(x => x.StartsWith("--scene="));
        if (sceneArg != null)
        {
            var scenePath = sceneArg.Substring("--scene=".Length);
            UiManager.SetMainTscn(scenePath);
        }
        // sceneArg 为 null 时，继续用默认主场景

        // 设置初始地
        var mapArg = args.FirstOrDefault(x => x.StartsWith("--map="));
        if (mapArg != null)
        {
            var mapPath = "res://scene/" + mapArg.Substring("--map=".Length) + ".tscn";
            DungeonManager.LoadMapPath = mapPath;
            DungeonManager.IsDebug = true;
        }
    }
}