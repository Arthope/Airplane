using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject _effectPrefab;
    [SerializeField] Rigidbody Rigidbody;
    [SerializeField] float ConstantForceValue;

    void FixedUpdate()
    {
        Rigidbody.AddForce(transform.forward * ConstantForceValue, ForceMode.VelocityChange);
    }

    public void Die()
    {
        Instantiate(_effectPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
