using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastDoor : MonoBehaviour
{

    private float maxRange = 50.0f;
    private float maxForce = 20.0f;
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
        timer = 0;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.left), out hit, maxRange))
        {
            hitPlayer = true;

            if(hit.rigidbody != null && hitPlayer)
            {
                timer += 1 * Time.deltaTime;
                Debug.Log("Timer is at: " + timer);

                rayDistance = hit.distance;
                //doorRB.AddForce(Vector3.left * maxForce, ForceMode.Force);
                while(timer < 4)
                {
                    OpenDoor();
                }
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.left) * rayDistance, Color.green);
                Debug.Log("Your ray hit at: " + hit.point);
            }
            else
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.left) * rayDistance, Color.red);
                hitPlayer = false;
                Debug.Log("Your ray did not hit anything");
            }
        }
    }

    void OpenDoor()
    {
        this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * maxForce, ForceMode.Force);
    }


}
