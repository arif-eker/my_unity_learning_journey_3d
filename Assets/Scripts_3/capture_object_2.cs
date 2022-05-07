using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capture_object_2 : MonoBehaviour
{

    GameObject myobj; // 1
    GameObject[] objarray; // 2
    public GameObject outobj; // 3

    void Start()
    {
        //GameObject.Find("MyCylinder").GetComponent<first_file_1>().age = 15;


        // 1.

        //myobj = GameObject.Find("MyCylinder");
        //myobj.GetComponent<first_file_1>().name_ = "Arif";
        //myobj.GetComponent<first_file_1>().age = 21;

        // 2.

        //myobj = GameObject.FindWithTag("SoS");
        //myobj.GetComponent<first_file_1>().name_ = "Arif";
        //myobj.GetComponent<first_file_1>().age = 21;

        // 3. example, only parents-child relationship
        //transform.Find("Child").GetComponent<first_file_1>().age = 15; // bu objenin çocuk objeleri için kullanılır

        // multi capture

        //objarray = GameObject.FindGameObjectsWithTag("SoS");

        //foreach (var item in objarray)
        //{
        //    item.GetComponent<first_file_1>().name_ = "Mesut";
        //    item.GetComponent<first_file_1>().age = 44;

        //}

        // 4

        //outobj.GetComponent<first_file_1>().age = 24;



        // 5

        // CapsuleCollider mycap = gameObject.GetComponent(typeof(CapsuleCollider)) as CapsuleCollider;
        //CapsuleCollider mycap = gameObject.GetComponent("CapsuleCollider") as CapsuleCollider;
        //mycap.isTrigger = true;
        //gameObject.name = "NewName";


        // 6

        //Camera camera =(Camera) FindObjectOfType(typeof(Camera));
        //if (camera)
        //{
        //    Debug.Log(camera.name);
        //}

        //Light lig = (Light)FindObjectOfType(typeof(Light));
        //if (camera)
        //{
        //    Debug.Log(lig.name);
        //}


        // gameObject.SetActive(false);

        //gameObject.CompareTag("Player");

        //Rigidbody new_rigid = gameObject.AddComponent<Rigidbody>() as Rigidbody;
        //new_rigid.mass = 3;

        //SphereCollider new_sphr = gameObject.AddComponent(typeof(SphereCollider)) as SphereCollider;
        //new_sphr.radius = 50;

    }






}
