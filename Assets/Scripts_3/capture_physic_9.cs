using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capture_physic_9 : MonoBehaviour
{


    //Rigidbody Collision'dan çarpışma yakalama

    private void OnCollisionEnter(Collision collision)
    {
        /*
         * Rigidbody sayesinde bu fonksiyonla fiziksel yakalamaları yapabiliriz.
         * Bu fonksiyon, bu obje başka bir obje ile etkileşime girdiğinde çalışır.
         * Etkileşime girdiği objenin Rigidbody'si olmasına gerek yok ama Collider'i olmalı.*/

        print("Collision detected.");


        //if (collision.gameObject.name == "b_green")
        //{
        //    // Çarpışmanın olduğu obje adı "b_green" ise burası çalışır.
        //    print("Collision detected with b_green object");
        //}



        //if (collision.gameObject.CompareTag("Player"))
        //{
        //    // Çarpışılan objenin tagı "Player" ise burası çalışır
        //    print("Player collision detected.");
        //}


        //if (collision.gameObject.name == "b_green")
        //{
        //    // çarpışılan obje adı "b_green" ise o objeyi yok eder.
        //    //Destroy(collision.gameObject);

        //    // İlgili objeyi çarpışma ile yok eder.
        //    Destroy(gameObject);
        //}


    }

    private void OnCollisionStay(Collision collision)
    {
        // Çarpışma sürekli devam ediyorsa bu fonksiyon çalışır.

        print("The collision continues.");

    }


    private void OnCollisionExit(Collision collision)
    {
        // Çarpışma bittiğinde bu fonksiyon çalışır. Yani dokunduktan sonra geri çekilme olduğunda gibi düşünebiliriz.

        print("The collision is over.");
    }




    // Collider'den çarpışma yakalama

    //private void OnTriggerEnter(Collider other)
    //{
    //    print("Collision detected.");


    //    //if (other.CompareTag("Player"))
    //    //{
    //    //    print("Player collision detected.");
    //    //}

    //    if (other.gameObject.name == "b_green")
    //    {
    //        // çarpışılan obje adı "b_green" ise o objeyi yok eder.
    //        //Destroy(other.gameObject);

    //        // İlgili objeyi çarpışma ile yok eder.
    //        Destroy(gameObject);
    //    }




    //}

    //private void OnTriggerStay(Collider other)
    //{
    //    print("The collision continues.");
    //}

    //private void OnTriggerExit(Collider other)
    //{
    //    print("The collision is over.");
    //}




}
