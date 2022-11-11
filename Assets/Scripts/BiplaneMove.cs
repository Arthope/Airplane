using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BiplaneMove : MonoBehaviour
{
    [SerializeField] Rigidbody Rigidbody;
    [SerializeField] private float _forceValue;
    [SerializeField] private float TorqueValue;
    [SerializeField] private float ConstantForceValue;

    void FixedUpdate()
    {      
        Rigidbody.AddForce(transform.forward * ConstantForceValue, ForceMode.VelocityChange);

        if (Input.GetKey(KeyCode.UpArrow))
        {
        Rigidbody.AddForce(transform.forward * _forceValue, ForceMode.VelocityChange);
        }

        float horizontalImput = Input.GetAxis("Horizontal");
        Rigidbody.AddTorque(transform.right * TorqueValue * horizontalImput, ForceMode.VelocityChange);
    }
}
