using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerationForce : MonoBehaviour
{

    /* (Christopher Green)
            * (AccelerationForce)
            * (Assignment 9)
            * (This code handles the Acceleration forcemode)
            */

    public Rigidbody rb;
    private float force = 100;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            rb.AddForce(Vector3.up * force, ForceMode.Acceleration);
        }
    }

}
