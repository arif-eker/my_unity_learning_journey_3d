using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ai_process : MonoBehaviour
{
    NavMeshAgent [] agents;
    public GameObject target;

    void Start()
    {
        agents = GetComponentsInChildren<NavMeshAgent>();
    }

    
    void Update()
    {
        foreach (var agent in agents)
        {
            agent.SetDestination(target.transform.position);
        }
    }
}
