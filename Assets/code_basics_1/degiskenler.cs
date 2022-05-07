using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class degiskenler : MonoBehaviour
{

    /*
        string
        int
        float
        double
        boolean

     */
    string my_str = "Hello, Arif";
    int age = 24;
    float num_one = 3.14f;
    double num_two = 3.1234;
    bool isopen = false;

    void Start()
    {
        Debug.Log(my_str);
        Debug.Log(age);
        Debug.Log(num_one);
        Debug.Log(num_two);
        Debug.Log(isopen);
        
    }

}
