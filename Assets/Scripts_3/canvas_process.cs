using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvas_process : MonoBehaviour
{

    public Text txt; // 1.
    public Image img; // 2.
    public Image health_img; // 3.

    void Start()
    {
        txt.text = "Hello World!";
        img.fillAmount = 0.5f;
       
    }


    void Update()
    {
        // Basic health bar animation
        if (health_img.fillAmount >= .00f)
        {
            health_img.fillAmount -= .1f * Time.deltaTime;

        }
        else
            health_img.fillAmount = .0f;

        if (Input.GetKeyDown(KeyCode.D))
        {
            health_img.fillAmount += .3f;
        }
        
    }
}
