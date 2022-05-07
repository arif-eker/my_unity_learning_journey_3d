using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invoke_methods : MonoBehaviour
{

    void Start()
    {
        Invoke("SayHello", 2f);
        // InvokeRepeating("SayHelloAgain", 2f, .9f);
    }


    public void SayHello()
    {
        Debug.Log("Hello there!");
    }

    public void SayHelloAgain()
    {
        Debug.Log("Hello again!");
        
    }
    private void Update()
    {
        if (IsInvoking("SayHello"))
        {
            Debug.Log("Working..");
            CancelInvoke("SayHello");
        }
        else
            Debug.Log("Doesn't working...");
    }

}
