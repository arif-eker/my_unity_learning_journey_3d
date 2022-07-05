using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast_bullet_system : MonoBehaviour
{

    public Transform gunPos;
    RaycastHit hit;

    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Debug.DrawRay(gunPos.position, gunPos.TransformDirection(new Vector3(0f, 0f, 1f)) * 50, Color.yellow);

            if (Physics.Raycast(gunPos.position, gunPos.TransformDirection(Vector3.forward), out hit, 100))
            {
                Debug.DrawRay(gunPos.position, gunPos.TransformDirection(new Vector3(0f, 0f, 1f)) * hit.distance, Color.red);

                hit.rigidbody.AddForce(Vector3.forward * 50); // special rigidboy: target's rigidbody
            }

        }
        
    }

    private void FixedUpdate()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(moveH, 0f, moveV) * 10 * Time.deltaTime);
    }


}
