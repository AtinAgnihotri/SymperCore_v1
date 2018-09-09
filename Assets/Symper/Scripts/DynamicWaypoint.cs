using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Assets.Symper.Scripts

{
    public class DynamicWaypoint : BasicWaypoint
    {

        [SerializeField]
        protected float _connectivityRadius = 25f;

        List<DynamicWaypoint> _connections;

        public void Start()
        {   
            //Grab all waypoints in the scene
            GameObject[] allWaypoints = GameObject.FindGameObjectsWithTag("Waypoint");

            //Create a list of waypoints to refer to later
            _connections = new List<DynamicWaypoint>();

            //Check if they're a dynamic waypoint
            for (int i = 0; i < allWaypoints.Length; i++)
            {
                DynamicWaypoint _nextWaypoint = allWaypoints[i].GetComponent<DynamicWaypoint>();

                //if we found a waypoint
                if (_nextWaypoint != null)
                {
                    if ((Vector3.Distance(this.transform.position, _nextWaypoint.transform.position) <= _connectivityRadius)  && (_nextWaypoint != this))
                    {
                        _connections.Add(_nextWaypoint);
                    }
                }
            }
        }

        public override void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, debugDrawRadius);

            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(transform.position, 25f);


        }

        public DynamicWaypoint NextWayPoint(DynamicWaypoint previousWaypoint)
        {
            if (_connections.Count == 0)
            {
                //No waypoints!! Return Null and Complain
                Debug.LogError("Insufficient Waypoints for Dynamic Patrol Behavior.");
                return null;
            }
            else if (_connections.Count == 1 && _connections.Contains(previousWaypoint))
            {
                //Only one waypoint and it's the previous one? Just use that
                return previousWaypoint;
            }
            else //Otherwise, find a new one that isn't the previous one
            {
                DynamicWaypoint nextWayPoint;
                int nextIndex = 0;

                do
                {
                    nextIndex = UnityEngine.Random.Range(0, _connections.Count);
                    nextWayPoint = _connections[nextIndex];
                } while (nextWayPoint == previousWaypoint);

                return nextWayPoint;
            }
        }

    }

}

