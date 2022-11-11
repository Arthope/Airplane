using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private AudioSource _sound;

    public void Die()
    {
        _sound.Play();
        Destroy(gameObject);
    }
}
