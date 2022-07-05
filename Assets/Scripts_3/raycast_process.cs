using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast_process : MonoBehaviour
{

    void Start()
    {

    }

    RaycastHit hit;
    //int layerMask = 1;
    //int layerMask = ~1;


    private void FixedUpdate()
    {
        //if (Physics.Raycast(transform.position, transform.TransformDirection(new Vector3(0f, 0f, 1f)), out hit, 50,layerMask)) // 3--> layerMask
        if (Physics.Raycast(transform.position, transform.TransformDirection(new Vector3(0f, 0f, 1f)), out hit, 50))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(new Vector3(0f, 0f, 1f)) * hit.distance, Color.yellow);
            //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);

            Debug.Log("Interaction");
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(new Vector3(0f, 0f, 1f)) * 50, Color.red);

            Debug.Log("No Interaction");
        }
    }



}
