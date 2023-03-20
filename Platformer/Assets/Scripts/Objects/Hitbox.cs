using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbox : MonoBehaviour
{
    [SerializeField] int _damage;
    [SerializeField] DeathStat _stat;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag != "Player")
            return;
        
        Player player = collider.GetComponent<Player>();
        player.SetState(new PlayerDeath(player, _stat));
    }
    
}
