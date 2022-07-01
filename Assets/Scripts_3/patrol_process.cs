using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class patrol_process : MonoBehaviour
{

    public GameObject destination_a;
    public GameObject destination_b;
    

    NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(destination_a.transform.position);
    }


    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "destination_a")
        {
            agent.SetDestination(destination_b.transform.position);
        }
        else
            agent.SetDestination(destination_a.transform.position);
    }



    //string dest_name = "dest_a";

    //void Start()
    //{
    //    agent = GetComponent<NavMeshAgent>();

    //}


    //void Update()
    //{
    //    if (dest_name == "dest_a")
    //    {
    //        agent.SetDestination(destination_a.transform.position);
    //    }
    //    else
    //        agent.SetDestination(destination_b.transform.position);
    //}
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.name == "destination_a")
    //    {
    //        dest_name = "dest_b";
    //    }
    //    else
    //        dest_name = "dest_a";
    //}
}
