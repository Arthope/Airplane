using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator : MonoBehaviour
{
    [SerializeField] private GameObject _coinPrefab;

    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            if(Random.Range(0,3) == 0)
            {
            Vector3 position = new Vector3(i, Random.Range(-15,15), 6);
            Instantiate(_coinPrefab, position, Quaternion.identity);
            }
        }
    }
}
