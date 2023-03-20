using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Move", menuName = "Player Statistics/Stat/Move")]
public class MoveStat : ScriptableObject
{
    public Animation Animation; 
    public float MoveSpeed; 
}
