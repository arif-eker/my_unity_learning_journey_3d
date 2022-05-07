using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class if_else : MonoBehaviour
{




    void Start()
    {


        int num_one = 5;
        int num_two = 10;

        if (num_one > num_two)
        {
            Debug.Log("Bigger!");
        }
        else
        {
            Debug.Log("Not Bigger!");
        }

    }

}
