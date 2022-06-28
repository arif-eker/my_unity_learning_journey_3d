using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation_controller : MonoBehaviour
{

    Animator animationController;

    void Start()
    {
        animationController = GetComponent<Animator>();
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            animationController.Play("walk");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animationController.Play("jump");
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            animationController.Play("sprint");
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            animationController.Play("idle");
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            animationController.Play("run");
        }

    }
}
