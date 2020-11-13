using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AIAgentScript : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform destination;
    
    
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        destination = transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        destination = other.transform;
    }
    
    
    private void Update()
    {
        agent.destination = destination.position;
    }
}