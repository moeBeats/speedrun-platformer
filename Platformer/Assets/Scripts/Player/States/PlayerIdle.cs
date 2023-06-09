using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdle : PlayerGrounded
{
    Player _player;
    public PlayerIdle(Player stateMachine) : base(stateMachine)
    {
        _player = (Player)stateMachine;    
    }
    public override void Enter()
    {
        base.Enter();
        _player.RemainingFloats = _player.StatSheet.Float.FloatCount;

    }
    public override void Update()
    {
        base.Update();

    }
    public override void Exit()
    {
        base.Exit();
    }
}
