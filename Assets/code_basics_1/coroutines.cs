using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coroutines : MonoBehaviour
{
    private IEnumerator my_cont;

    void Start()
    {
        my_cont = ExampleCoroutine(2);
        StartCoroutine(my_cont);
    }

    IEnumerator ExampleCoroutine(int seconds)
    {
        Debug.Log("First");

        yield return null;

        Debug.Log("Second");


        while (true)
        {
            yield return new WaitForSeconds(seconds);


            Debug.Log("After " + seconds + " seconds");
        }



    }

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("Stop...");
            StopCoroutine(my_cont);
            // StopAllCoroutines();
        }
    }


}
