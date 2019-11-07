using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/* (Christopher Green)
        * (ForceForceMode)
        * (Assignment 9)
        * (This code handles the Force/default forcemode)
        */

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
