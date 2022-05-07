using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class message_functions : MonoBehaviour
{

    /*
      Function Order:
      
        1- Awake()
        2- OnEnable()
        3- Start()
        4- FixedUpdate()
        5- Update()
        6- LateUpdate()
        7- OnDisable()
     
     */

    private void Awake()
    {
        Debug.Log("Awake working...");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable working...");
    }

    void Start()
    {
        Debug.Log("Start working...");
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate working...");
    }


    void Update()
    {
        Debug.Log("Update working...");

    }

    private void LateUpdate()
    {
        Debug.Log("LateUpdate working...");
    }

    private void OnDisable()
    {
        Debug.Log("OnDiasble working...");
    }


}
