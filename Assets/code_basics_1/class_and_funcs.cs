using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class class_and_funcs : MonoBehaviour
{

    void Start()
    {
        Debug.Log("Start func. working..");
    }

}

public class MyClass
{

    public void SayHello()
    {
        Debug.Log("Hello func working.");
    }


}

public class HelloClass: MyClass
{

    MyClass student = new MyClass();
    

    public void SayHelloAgain()
        
    {
        student.SayHello();
        Debug.Log("Hello");
    }


}

