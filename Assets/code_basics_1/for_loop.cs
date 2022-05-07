using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class for_loop : MonoBehaviour
{

    void Start()
    {
        for (int i = 0; i < 5; i++)
        {

            if (i == 3)
            {
                break;
            }
            Debug.Log("i: " + i);

        }

    }


}
