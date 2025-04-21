
using System.Text.Json;
using Godot;

[EffectFragment(
    "PiggyBank",
    "存钱罐, 使用后返还存入的金币",
    Arg1 = "(float)返还金币的倍率, 范围0-1"
)]
public class Eff_PiggyBank : EffectFragment
{
    private float _value;
    //当前存入的金币数量
    private float _currValue;
    
    public override void InitParam(JsonElement[] arg)
    {
        _value = arg[0].GetSingle();
    }

    public override bool OnCheckUse()
    {
        return _currValue > 0;
    }

    public override void OnUse()
    {
        Gold.CreateGold(Role.Position, Mathf.FloorToInt(_currValue * _value));

        _currValue = 0;
    }

    public override void OnPickUpItem()
    {
        Role.RoleState.CalcGetGoldEvent += OnCalcGetGoldEvent;
    }

    public override void OnRemoveItem()
    {
        Role.RoleState.CalcGetGoldEvent -= OnCalcGetGoldEvent;
    }
    
    private void OnCalcGetGoldEvent(int origin, RefValue<int> refValue)
    {
        _currValue += refValue.Value;
        refValue.Value = 0;
    }
}