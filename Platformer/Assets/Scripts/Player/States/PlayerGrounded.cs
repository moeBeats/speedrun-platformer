using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrounded : State
{
    Player _player;
    public PlayerGrounded(Player stateMachine) : base(stateMachine)
    {
        _player = (Player)stateMachine;    
    }
    public override void Enter()
    {
        base.Enter();
    }
    public override void Update()
    {
        base.Update();

        if (_player.Direction != 0)
        {
            if (_player.IsHoldingRun)
                StateMachine.SetState(new PlayerMove(_player, _player.StatSheet.Run));
            else
                StateMachine.SetState(new PlayerMove(_player, _player.StatSheet.Walk));
        }
        else
        {
            StateMachine.SetState(new PlayerIdle(_player));
        }

        if (_player.IsHoldingJump && _player.GroundCheck.IsGrounded())
        {
            if (_player.IsHoldingRun)
                StateMachine.SetState(new PlayerJump(_player,_player.StatSheet.JumpRun));
            else
                StateMachine.SetState(new PlayerJump(_player,_player.StatSheet.JumpWalk));
        }

    }
    public override void Exit()
    {
        base.Exit();
    }
}
