using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Statistic Sheet", menuName = "Player Statistics/Sheet")]
public class StatSheet : ScriptableObject
{
    public MoveStat Walk;
    public MoveStat Run;
    public JumpStat JumpWalk;
    public JumpStat JumpRun;
    public FloatStat Float;
    public JumpStat Fall;
}
