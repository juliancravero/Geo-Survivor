using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNav : MonoBehaviour
{
    private Transform target;

    NavMeshAgent agent;

    private void Start()
    {
      if(GameObject.FindGameObjectWithTag("Player")){
        target = GameObject.FindGameObjectWithTag("Player").transform;
      }
      agent = GetComponent<NavMeshAgent>();
      agent.updateRotation = false;
      agent.updateUpAxis = false;  
    }

    private void Update() {
        agent.SetDestination(target.position);
    }
}

