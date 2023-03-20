using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    protected StateMachine StateMachine;
    public State(StateMachine stateMachine)
    {
        StateMachine = stateMachine;
    }
    public virtual void Enter()
    {
    }
    public virtual void Update()
    {
    }
    public virtual void Exit()
    {
    }
    public virtual void OnCollisionEnter(Collision2D collision)
    {
    }

}
