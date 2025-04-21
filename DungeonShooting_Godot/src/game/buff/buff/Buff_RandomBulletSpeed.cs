
using System.Text.Json;

[BuffFragment(
    "RandomBulletSpeed", 
    "子弹增加随机速度 buff, 会从上限和下限随机抽取值",
    Arg1 = "(float)增加子弹速度下限",
    Arg2 = "(float)增加子弹速度上限"
)]
public class Buff_RandomBulletSpeed : BuffFragment
{
    private float _min;
    private float _max;
    
    public override void InitParam(JsonElement[] args)
    {
        _min = args[0].GetSingle();
        _max = args[1].GetSingle();
    }
    
    public override void OnPickUpItem()
    {
        Role.RoleState.CalcBulletSpeedEvent += CalcBulletSpeedEvent;
    }
    
    public override void OnRemoveItem()
    {
        Role.RoleState.CalcBulletSpeedEvent -= CalcBulletSpeedEvent;
    }
    
    private void CalcBulletSpeedEvent(float originSpeed, RefValue<float> speed)
    {
        speed.Value += originSpeed * Utils.Random.RandomRangeFloat(_min, _max);
    }
}