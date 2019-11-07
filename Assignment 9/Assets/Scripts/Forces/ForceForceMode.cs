using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceForceMode : MonoBehaviour
{
    public Rigidbody rb;
    private float force = 100;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            rb.AddForce(Vector3.up * force, ForceMode.Force);
        }
    }
}
