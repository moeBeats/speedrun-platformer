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
        Rigidbody2D colliderRb = collider.GetComponent<Rigidbody2D>();
            Debug.Log(collider);

        if (collider.tag == "Player")
        {
            Player player = collider.GetComponent<Player>();
            player.SetState(new PlayerJump(player, _jump));
        }
        else if (colliderRb != null)
        {
            colliderRb.velocity = _jump.Velocity;
        }
            
        
    }
}
