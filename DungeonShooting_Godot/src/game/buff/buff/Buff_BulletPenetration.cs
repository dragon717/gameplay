
using System.Text.Json;

[BuffFragment(
    "BulletPenetration",
    "子弹穿透次数 buff",
    Arg1 = "(int)子弹增加的穿透次数"
)]
public class Buff_BulletPenetration : BuffFragment
{
    private int _value;

    public override void InitParam(JsonElement[] args)
    {
        _value = args[0].GetInt32();
    }

    public override void OnPickUpItem()
    {
        Role.RoleState.CalcBulletPenetrationEvent += CalcBulletPenetrationEvent;
    }

    public override void OnRemoveItem()
    {
        Role.RoleState.CalcBulletPenetrationEvent -= CalcBulletPenetrationEvent;
    }

    private void CalcBulletPenetrationEvent(int origin, RefValue<int> penetration)
    {
        penetration.Value += _value;
    }
}