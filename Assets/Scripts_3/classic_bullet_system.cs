using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class classic_bullet_system : MonoBehaviour
{


    public GameObject bullet;
    public Transform gunPos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Instantiate(bullet, gunPos.position, Quaternion.identity);
        }
    }

    private void FixedUpdate()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(moveH,0f,moveV) * 15 * Time.deltaTime);
    }

}
