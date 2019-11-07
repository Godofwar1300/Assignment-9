using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpulseForce : MonoBehaviour
{


    /* (Christopher Green)
            * (ImpulseForce)
            * (Assignment 9)
            * (This code handles the Impulse forcemode)
            */

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
