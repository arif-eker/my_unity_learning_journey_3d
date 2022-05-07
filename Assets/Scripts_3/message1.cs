using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class message1 : MonoBehaviour
{

    void Start()
    {
        gameObject.SendMessage("Greeting", "Arif");
        //gameObject.SendMessage("Greeting", "Arif", SendMessageOptions.DontRequireReceiver); // Alıcı fonk. yoksa hata verdirmez.
        gameObject.BroadcastMessage("SaySomething");
    }


    void Greeting(string name)
    {
        Debug.Log("Hello " + name);
    }
    void SaySomething()
    {
        Debug.Log("My name is : " + gameObject.name);
    }

    void Update()
    {
        
    }
}
