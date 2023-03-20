using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoint : MonoBehaviour
{
    [SerializeField] GameObject _playerPrefab;
    void Start()
    {
        Spawn();
    }

    public void Spawn()
    {
        Instantiate(_playerPrefab,transform.position, Quaternion.identity);    
    }

}
