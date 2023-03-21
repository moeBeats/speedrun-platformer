using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    [SerializeField] Vector SpawnPoint;
    void OnTriggerEnter2D(Collider2D collider)
    {
        SpawnPoint.Value = transform.position;
    }
}
