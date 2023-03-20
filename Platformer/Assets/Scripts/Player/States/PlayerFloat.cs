using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFloat : State
{
    Player _player;
    FloatStat  _stat;

    public PlayerFloat(Player stateMachine, FloatStat floatStat) : base(stateMachine)
    {
        _player = (Player)stateMachine;
        _stat = floatStat; 
    }
    public override void Enter()
    {
        base.Enter();
        _player.Rb.velocity = Vector2.zero;
        _player.Rb.gravityScale = _stat.GravityScale;
    }
    public override void Update()
    {
        base.Update();

        _player.Flip();
        StateMachine.transform.position += new Vector3(_stat.MoveSpeed *_player.Direction * Time.fixedDeltaTime, 0);


        if (_player.GroundCheck.IsGrounded() && _stat.IsFalling(_player.Rb))
            StateMachine.SetState(new PlayerIdle(_player));

        if (!_player.IsHoldingJump)
            StateMachine.SetState(new PlayerJump(_player, _player.StatSheet.Fall));

        //Debug.Log(IsFalling);
    }
    public override void Exit()
    {
        base.Exit();
        _player.IsHoldingJump = false;
    }

}
