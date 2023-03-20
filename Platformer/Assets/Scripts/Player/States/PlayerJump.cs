using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : State
{
    Player _player;
    int _index;
    JumpStat  _stat;

    public PlayerJump(Player stateMachine, JumpStat jumpStat) : base(stateMachine)
    {
        _player = (Player)stateMachine;
        _stat = jumpStat; 

    }
    public override void Enter()
    {
        base.Enter();
        _player.IsHoldingJump = false;

        _player.Rb.velocity = _stat.Velocity;
        _player.Rb.gravityScale = _stat.GravityScale;
    }
    public override void Update()
    {
        base.Update();

        _player.Flip();
        StateMachine.transform.position += new Vector3(_stat.MoveSpeed *_player.Direction * Time.fixedDeltaTime, 0);

        if (_stat.IsFalling(_player.Rb))
        {
            if (_player.GroundCheck.IsGrounded())
                StateMachine.SetState(new PlayerIdle(_player));

            if (_player.IsHoldingJump)
                StateMachine.SetState(new PlayerFloat(_player, _player.StatSheet.Float));
        }
        //Debug.Log(IsFalling);
    }
    public override void Exit()
    {
        base.Exit();
    }

}
