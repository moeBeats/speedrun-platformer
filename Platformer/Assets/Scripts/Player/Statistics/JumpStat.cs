using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Jump", menuName = "Player Statistics/Stat/Jump")]
public class JumpStat : AirStat
{
    public Animation Animation; 
    public Vector2 Velocity;
    public float MoveSpeed;

}
