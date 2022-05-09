using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_manager : MonoBehaviour
{

    public Camera Main_Camera;
    public Camera Second_Camera;
    public Camera Third_Camera;

    void Update()
    {


        if (Input.GetKeyDown(KeyCode.A))
        {
            Main_Camera.enabled = true;
            print("Main Camera vision active");
            Second_Camera.enabled = false;           
            Third_Camera.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Main_Camera.enabled = false;
            Second_Camera.enabled = true;
            print("Second Camera vision active");
            Third_Camera.enabled = false;
        }
        
        if (Input.GetKeyDown(KeyCode.D))
        {
            Main_Camera.enabled = false;
            Second_Camera.enabled = false;
            Third_Camera.enabled = true;
            print("Third Camera vision active");
        }


    }
}
