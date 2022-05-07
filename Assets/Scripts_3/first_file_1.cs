using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class first_file_1 : MonoBehaviour
{


    public string name_;
    public int age;
    public float salary;
    private string city;
    public bool isAlive;
    public string[] children;

    CapsuleCollider myCapsule;
    

    void Start()
    {
        city = "Bursa";
        Debug.Log("Hello");
        Debug.Log(name_);
        Debug.Log(age);
        Debug.Log(salary);
        Debug.Log(city);
        //if (isAlive)
        //{
        //    Debug.Log("Lives..");
        //}
        //else
        //    Debug.Log("Doesn't live...");

        //foreach (var child in children)
        //{
        //    Debug.Log(child);
        //}


        //myCapsule = GetComponent<CapsuleCollider>();
        //myCapsule.height = 5;
        //myCapsule.enabled = false;

        //CapsuleCollider[] myCapsules = GetComponents<CapsuleCollider>();
        //foreach (var item in myCapsules)
        //{
        //    item.isTrigger = true;
        //}

        //GetComponentInParent<>();
        //GetComponentInChildren<>();



    }

    void Update()
    {

    }
}
