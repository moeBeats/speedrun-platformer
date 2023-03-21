using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : StateMachine
{
    public StatSheet StatSheet;
    public float Direction = 0; 
    public bool IsHoldingRun = false;
    public bool IsHoldingJump = false;
    bool isFacingRight = true; 
    [HideInInspector] public Rigidbody2D Rb;
    [HideInInspector] public GroundCheck GroundCheck;
    public int RemainingFloats;

    public override State InitialState()
    {
        return new PlayerIdle(this);
    }
    void Awake()
    {
        Rb = GetComponent<Rigidbody2D>();
        GroundCheck = GetComponent<GroundCheck>();
        RemainingFloats = StatSheet.Float.FloatCount;
    }
    public void Flip()
    {
        if (isFacingRight && Direction < 0 || !isFacingRight && 0 < Direction)
        {
            isFacingRight = !isFacingRight;

            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
