using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpulseForce : MonoBehaviour
{
    public Rigidbody rb;
    private float force = 100;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
        }
    }
}
