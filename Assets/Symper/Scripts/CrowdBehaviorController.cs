using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CrowdBehaviorController : MonoBehaviour {

    public Transform[] homes; 

    [SerializeField]
    NavMeshAgent[] agents;

	void Start () { 
        for (int i = 0; i < agents.Length; i++)
        {
            for (int j = 0; j < homes.Length; j++)
            {
                if (agents[i].tag == homes[j].tag)
                {
                    agents[i].SetDestination(homes[j].position);
                }
            }
        }
	}
	
	void FixedUpdate () {
		
	}
}
