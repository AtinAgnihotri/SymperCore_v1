using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BasicPatrolController : MonoBehaviour
{
    //List of all Basic Waypoints to visit
    [SerializeField]
    List<BasicWaypoint> _patrolPoints;

    NavMeshAgent _navMeshAgent;

    //Dictates whether agent waits on each node
    [SerializeField]
    bool _patrolWaiting;

    //Total time we wait on each node
    [SerializeField]
    float _totalWaitTime = 3f;

    //The Probability of switching directions
    [SerializeField]
    float _switchProbability = 0.2f;

    int _currentPatrolIndex;
    bool _travelling;
    bool _waiting;
    bool _patrolForward;
    float _waitTimer;

	void Start () {
        _navMeshAgent = GameObject.Find("NPC").GetComponent<NavMeshAgent>();

        if (_navMeshAgent == null)
        {
            Debug.Log("NavMesh Agent Not Found!");
        }
        else
        {
            if (_patrolPoints != null && _patrolPoints.Count >= 2)
            {
                _currentPatrolIndex = 0;
                SetDestination();
            }
            else
            {
                Debug.Log("Insufficient Patrol Points for Basic Patrol Behavior.");
            }
        }
	}

    private void SetDestination()
    {
        if (_patrolPoints != null)
        {
            Vector3 targetVector = _patrolPoints[_currentPatrolIndex].transform.position;
            _navMeshAgent.SetDestination(targetVector);
            _travelling = true;
        }
    }

    void FixedUpdate () {
        //To check if we're close to the destination
        if (_travelling && _navMeshAgent.remainingDistance <= 1.0f)
        {
            _travelling = false;

            //If we're going to wait, then wait
            if (_patrolWaiting)
            {
                _waiting = true;
                _waitTimer = 0f;
            }
            else
            {
                ChangePatrolPoints();
                SetDestination();
            }
        }

        //Instead, if we're waiting
        if (_waiting)
        {
            _waitTimer += Time.deltaTime;

            if (_waitTimer >= _totalWaitTime)
            {
                _waiting = false;

                ChangePatrolPoints();
                SetDestination();
            }
        }
	}

    /// <summary>
    /// Selects a new patrol point in the available list, but
    /// also with a small probability of moving forward or backwards.
    /// </summary>
    private void ChangePatrolPoints()
    {
        if (UnityEngine.Random.Range(0f, 1f) <= _switchProbability)
        {
            _patrolForward = !_patrolForward;
        }

        if (_patrolForward)
        {
            _currentPatrolIndex = (_currentPatrolIndex + 1) % _patrolPoints.Count;
        }
        else
        {
            if (- -_currentPatrolIndex < 0)
            {
                _currentPatrolIndex = _patrolPoints.Count - 1;
            }
        }
    }
}
