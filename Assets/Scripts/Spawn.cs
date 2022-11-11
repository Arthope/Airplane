using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawn : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private float _delay;
    [SerializeField] private Transform[] _spawnPoints;

    private void Start()
    {
        StartCoroutine(Spawner());
    }

    private IEnumerator Spawner()
    {
        var wait = new WaitForSeconds(_delay);
        while (true)
        {
            int spawnPointNumber = Random.Range(0, _spawnPoints.Length);
            Instantiate(_enemyPrefab, _spawnPoints[spawnPointNumber]);
            yield return wait;
        }
    }
}

