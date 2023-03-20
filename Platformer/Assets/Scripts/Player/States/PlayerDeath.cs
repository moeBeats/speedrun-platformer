using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : State
{
    Player _player;
    int _index;
    DeathStat  _stat;

    public PlayerDeath(Player stateMachine, DeathStat deathStat) : base(stateMachine)
    {
        _player = (Player)stateMachine;
        _stat = deathStat; 
    }
    public override void Enter()
    {
        base.Enter();
        _player.StartCoroutine(Death());
    }
    public override void Update()
    {
        base.Update();
    }
    public override void Exit()
    {
        base.Exit();
    }
    IEnumerator Death()
    {
        yield return new WaitForSeconds(.5f);
        _stat.Event.Raise();
        GameObject.Destroy(_player.gameObject);
    }
}
