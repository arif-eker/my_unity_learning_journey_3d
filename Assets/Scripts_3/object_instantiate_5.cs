using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class object_instantiate_5 : MonoBehaviour
{


    public GameObject ins_obj;



    void Start()
    {
        // Instantiate(ins_obj); // obje oluşturuldu - clone edildi

        // Instantiate(ins_obj,transform); // obje oluşturuldu, bu scriptin olduğu objenin child'i oldu ama

        // Instantiate(ins_obj, transform.position, transform.rotation); // bu sefer child olmaz, bu objenin sahip olduğu değerler ile oluşturulur
        // Instantiate(ins_obj, transform.position, Quaternion.identity);
        // Instantiate(ins_obj, new Vector3(2f,3f,10f), Quaternion.identity);


        GameObject ex_obj = Instantiate(ins_obj, new Vector3(2f,3f,10f), Quaternion.identity);
        
    }


    void Update()
    {
        
    }
}
