using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : PlayerGrounded
{
    Player _player;
    int _index;
    MoveStat  _stat;
    public PlayerMove(Player stateMachine, MoveStat movementStat) : base(stateMachine)
    {
        _player = (Player)stateMachine;
        _stat = movementStat; 
    }
    public override void Enter()
    {
        base.Enter();
    }
    public override void Update()
    {
        base.Update();

        _player.Flip();
        StateMachine.transform.position += new Vector3(_stat.MoveSpeed *_player.Direction * Time.fixedDeltaTime, 0);        
    }
    public override void Exit()
    {
        base.Exit();
    }
}
