using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class while_loops : MonoBehaviour
{


    void Start()
    {
        int number = 0;

        while (number <= 3)
        {
            if (number == 2)
            {
                number++;
                continue;
            }
            else
            { Debug.Log("Number is:" + number); }

            number++;
        }

        Debug.Log("Secret Number Lines..");

        int secret_number = 5;
        do
        {
            Debug.Log(secret_number * secret_number);
            secret_number++;

        } while (secret_number<10);

    }



}
