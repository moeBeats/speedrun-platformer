using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoint : MonoBehaviour
{
    [SerializeField] GameObject _playerPrefab;
    [SerializeField] Vector _spawnPoint;
    void Start()
    {
        _spawnPoint.Value = transform.position;
        Spawn();
    }

    public void Spawn()
    {
        Instantiate(_playerPrefab,_spawnPoint.Value, Quaternion.identity);    
    }

}
