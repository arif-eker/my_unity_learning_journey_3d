using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lists : MonoBehaviour
{
    
    void Start()
    {

        List<int> ages = new List<int>();

        ages.Add(50);
        ages.Add(42);
        ages.Add(45);

        Debug.Log(ages.Count); // 3 lenght of ages list

        List<string> names = new List<string>();

        names.Add("Maria");
        names.Add("James");
        names.Add("Lisa");

        Debug.Log("Hello "+names[1]);

        foreach (var item in names)
        {
            Debug.Log(item);
        }


        names.Insert(1, "Stephen");
        Debug.Log("Names List Count: " + names.Count);

        foreach (var item in names)
        {
            Debug.Log(item);
        }

        names.Remove("Maria");

        if (names.Contains("Maria"))
        {
            Debug.Log("Maria is here!");

        }
        else
            Debug.Log("Maria is not here!");


    }


    
}
