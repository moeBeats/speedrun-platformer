using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Air", menuName = "Player Statistics/Stat/Air")]
public class AirStat : ScriptableObject
{
    public float GravityScale = 3f;
    public float FallMin = 5f;

    public bool IsFalling(Rigidbody2D rb) => rb.velocity.y < FallMin;

}
