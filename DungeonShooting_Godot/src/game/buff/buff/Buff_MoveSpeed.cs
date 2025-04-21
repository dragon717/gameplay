
using System.Text.Json;

[BuffFragment(
    "MoveSpeed",
    "增加移速 buff",
    Arg1 = "(float)增加的移动速度值"
)]
public class Buff_MoveSpeed : BuffFragment
{
    private float _moveSpeed;
    
    public override void InitParam(JsonElement[] args)
    {
        _moveSpeed = args[0].GetSingle();
    }

    public override void OnPickUpItem()
    {
        Role.RoleState.MoveSpeed += _moveSpeed;
        Role.RoleState.Acceleration += _moveSpeed * 1.4f;
        Role.RoleState.Friction += _moveSpeed * 10;
    }

    public override void OnRemoveItem()
    {
        Role.RoleState.MoveSpeed -= _moveSpeed;
        Role.RoleState.Acceleration -= _moveSpeed * 1.4f;
        Role.RoleState.Friction -= _moveSpeed * 10;
    }
}