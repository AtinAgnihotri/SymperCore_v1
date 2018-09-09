using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Assets.Symper.Scripts
{
    public class DynamicPatrolController : MonoBehaviour
    {
        /*
        //List of all Basic Waypoints to visit
        [SerializeField]
        List<BasicWaypoint> _patrolPoints;*/

        DynamicWaypoint _currentWaypoint;
        DynamicWaypoint _previousWaypoint;

        NavMeshAgent _navMeshAgent;

        //Dictates whether agent waits on each node
        [SerializeField]
        bool _patrolWaiting;

        //Total time we wait on each node
        [SerializeField]
        float _totalWaitTime = 3f;

        //The Probability of switching directions/*
        /*[SerializeField]
        float _switchProbability = 0.2f;*/

        int _currentPatrolIndex;
        bool _travelling;
        bool _waiting;
        bool _patrolForward;
        float _waitTimer;

        static int _waypointsVisited = 0;

        void Start()
        {
            _navMeshAgent = GameObject.Find("NPC").GetComponent<NavMeshAgent>();

            if (_navMeshAgent == null)
            {
                Debug.Log("NavMesh Agent Not Found!");
            }
            else
            {
                if (_currentWaypoint == null)
                {
                    //Set it at Random
                    //Grab all waypoint objects in the scene
                    GameObject[] allWaypoints = GameObject.FindGameObjectsWithTag("Waypoint");

                    if (allWaypoints.Length > 0)
                    {
                        while (_currentWaypoint == null)
                        {
                            int random = UnityEngine.Random.Range(0, allWaypoints.Length);
                            DynamicWaypoint startingWaypoint = allWaypoints[random].GetComponent<DynamicWaypoint>();

                            if (startingWaypoint != null)
                            {
                                _currentWaypoint = startingWaypoint;
                            }
                        }
                    }
                }
                else
                {
                    Debug.LogError("Failed to Find any waypoints in the scene!");
                }
            }

            SetDestination();
        }

        private void SetDestination()
        {
            if (_waypointsVisited > 0)
            {
                DynamicWaypoint nextWaypoint = _currentWaypoint.NextWayPoint(_previousWaypoint);
                _previousWaypoint = _currentWaypoint;
                _currentWaypoint = nextWaypoint;
            }

            Vector3 targetVector = _currentWaypoint.transform.position;
            _navMeshAgent.SetDestination(targetVector);
            _travelling = true;
        }

        void FixedUpdate()
        {
            //To check if we're close to the destination
            if (_travelling && _navMeshAgent.remainingDistance <= 1.0f)
            {
                _travelling = false;
                _waypointsVisited++;

                //If we're going to wait, then wait
                if (_patrolWaiting)
                {
                    _waiting = true;
                    _waitTimer = 0f;
                }
                else
                {
                    //ChangePatrolPoints();
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

                    //ChangePatrolPoints();
                    SetDestination();
                }
            }
        }

        /// <summary>
        /// Selects a new patrol point in the available list, but
        /// also with a small probability of moving forward or backwards.
        /// </summary>
        /*private void ChangePatrolPoints()
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
        }*/
    }

}
