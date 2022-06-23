using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser_effect : MonoBehaviour
{
    public Transform target;
    LineRenderer laser_line;
    void Start()
    {
        laser_line = GetComponent<LineRenderer>();
        
    }

    
    void Update()
    {
        

        if(Vector3.Distance(transform.position, target.position)>10f)
        {
            Debug.Log("Over Distance!");
            laser_line.enabled = false;
        }
        else
        {
            laser_line.enabled = true;
            laser_line.SetPosition(0, transform.position);
            laser_line.SetPosition(1, target.position);
        }

    }
}
