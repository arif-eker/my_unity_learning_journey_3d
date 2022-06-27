using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation_process : MonoBehaviour
{
    Animator animationController;
    void Start()
    {
        animationController = GetComponent<Animator>();
    }


    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            animationController.SetTrigger("to_jump");
        }

        if (Input.GetKeyDown("w"))
        {
            animationController.SetTrigger("to_move");
        }

        if (Input.GetKeyDown("c"))
        {
            animationController.ResetTrigger("to_move");
        }
    }
}
