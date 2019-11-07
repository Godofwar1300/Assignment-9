using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* (Christopher Green)
        * (VelocityChangeForce)
        * (Assignment 9)
        * (This code handles the VelocityChange forcemode)
        */

public class VelocityChangeForce : MonoBehaviour
{
    public Rigidbody rb;
    private float force = 100;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            rb.AddForce(Vector3.up * force, ForceMode.VelocityChange);
        }
    }
}
