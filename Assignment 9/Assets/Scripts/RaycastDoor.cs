using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
		 * (Christopher Green)
		 * (RaycastDoor)
		 * (Assignment 9)
		 * (This code handles the opening of the door when the player gets close to it)
         * NOTE: DrawRay does not work for some reason and I have tried putting it just in the update and it still doesn't work.
         * I am sure the code is right but hopefully i don't lose too many points.
		 */



public class RaycastDoor : MonoBehaviour
{

    private float maxRange = 50.0f;
    private float maxForce = 40.0f;
    private float rayDistance;
    private bool hitPlayer = false;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        //timer = 0;
        Debug.Log("Timer is at: " + timer);
        Debug.Log("hitPlayer is: " + hitPlayer);

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.left), out hit, maxRange))
        {
            hitPlayer = true;

            if (hit.rigidbody != null && hitPlayer)
            {
                timer += 1 * Time.deltaTime;
                Debug.Log("Timer is at: " + timer);

                rayDistance = hit.distance;
                //doorRB.AddForce(Vector3.left * maxForce, ForceMode.Force);
                if (timer <= .5f)
                {
                    OpenDoor();
                }
                else
                {
                    timer = 0;
                }
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.left) * rayDistance, Color.green);
                Debug.Log("Your ray hit at: " + hit.point);
            }
            else
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.left) * rayDistance, Color.red);
                hitPlayer = false;
                timer = 0;
                Debug.Log("Your ray did not hit anything");
            }
        }
    }

    void OpenDoor()
    {
        //this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.left * (maxForce), ForceMode.Force);
        this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * maxForce, ForceMode.Force);
    }
}
