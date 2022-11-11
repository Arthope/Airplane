using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BiplaneTrigger : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private Score _score;

   private void OnTriggerEnter(Collider other)
    {
        Enemy enemy = other.gameObject.GetComponent<Enemy>();
        if (enemy)
        {
            _health -= 1;
            if (_health <= 0)
            {
                Destroy(gameObject);
            }
            enemy.Die();
        }

        Coin coin = other.gameObject.GetComponent<Coin>();
        if (coin)
        {
            coin.Die();
            _score.AddOne();
        }
    }
    
}
