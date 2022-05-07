using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foreach_loop : MonoBehaviour
{

    void Start()
    {

        string[] items = { "apple", "banana", "peach", "coconut" };
        int count = 0;

        foreach (var item in items)
        {


            Debug.Log((count+1)+"  Item Name: " + item);
            count++;
        }

    }


}
