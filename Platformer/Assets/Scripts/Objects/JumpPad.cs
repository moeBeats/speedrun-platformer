using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    [SerializeField] JumpStat _jump;
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag != "Player")
            return;
        
        Player player = collider.GetComponent<Player>();
        player.SetState(new PlayerJump(player, _jump));
    }
}
