using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array : MonoBehaviour
{


    void Start()
    {
        int[] numbers = new int[5];
        string[] my_strings = new string[5];

        int[] numbers_two = new int[] { 1, 3, 5, 6, 7 };
        int[] numbers_three = new int[4] { 11, 12, 13, 14 };
        int[] numbers_four = { 41, 42, 43 };


        for (int i = 0; i < numbers_two.Length; i++)
        {
            Debug.Log(numbers_two[i]);
        }


        string[][] cars = new string[3][];

        cars[0] = new string [] {"BMW","AUDI","PORSCHE"};
        cars[1] = new string[] { "2020", "2021", "2016" };
        cars[2] = new string[] { "180hp", "180hp", "240hp" };

        for (int i = 0; i < cars.Length; i++)
        {
            for (int j = 0; j < cars[i].Length; j++)
            {
                Debug.Log(cars[j][i]);
            }
        }

    }


}
