using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCMove : MonoBehaviour {

    [SerializeField]
    Transform _destination;

    NavMeshAgent _navMeshAgent;

	// Use this for initialization
	void Start () {
        _navMeshAgent = GameObject.Find("NPC").GetComponent<NavMeshAgent>();
        //Debug.Log(_navMeshAgent.gameObject.name);

        if (_navMeshAgent == null)
        {
            Debug.LogError("The NavMesh Agent not Found. Attach NavMesh Agent to" + GameObject.Find("NPC").gameObject.name);
        }
        else
        {
            SetDestination();
        }
	}

    private void SetDestination()
    {
        if (_destination != null)
        {
            Vector3 target = _destination.transform.position;
            _navMeshAgent.SetDestination(target);
        }
        else
        {

        }
    }

}
