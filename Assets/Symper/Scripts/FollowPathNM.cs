using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPathNM : MonoBehaviour {

    public GameObject wpManager;
    GameObject[] wps;
    GameObject currentNode;

    NavMeshAgent agent;

    // Use this for initialization
    void Start() {
        wps = wpManager.GetComponent<WPManager>().waypoints;
        agent = this.GetComponent<NavMeshAgent>();
        currentNode = wps[0];
    }

    public void GoToHelipad()
    {
        agent.SetDestination(wps[1].transform.position);
        currentNode = wps[1];
       /* g.AStar(currentNode, wps[1]);
        currentWP = 0;*/
    }

    public void GoToRuin()
    {
        agent.SetDestination(wps[7].transform.position);
        currentNode = wps[7];
        /*g.AStar(currentNode, wps[7]);
        currentWP = 0;*/
    }

    public void GoToMesa()
    {
        agent.SetDestination(wps[4].transform.position);
        currentNode = wps[4];
        /*g.AStar(currentNode, wps[4]);
        currentWP = 0;*/
    }

    public void GoPrevious()
    {
        int ch = 0;

        for (int i = 0; i < wps.Length; i++)
        {
            if (wps[i].gameObject.name == currentNode.gameObject.name)
            {
                ch = i;
            }
        }

        if (ch > 0)
        {
            agent.SetDestination(wps[ch - 1].transform.position);
            currentNode = wps[ch - 1];

        }
        else
        {
            agent.SetDestination(wps[wps.Length - 1].transform.position);
            currentNode = wps[wps.Length - 1];
        }
            

        //currentWP = 0;
    }

    public void GoNext()
    {
        int ch = 0;

        for (int i = 0; i < wps.Length; i++)
        {
            if (wps[i].gameObject.name == currentNode.gameObject.name)
            {
                ch = i;
            }
        }

        if (ch < wps.Length - 1)
            agent.SetDestination(wps[ch + 1].transform.position);
        else
            agent.SetDestination(wps[0].transform.position);

       // currentWP = 0;
    }

    // Update is called once per frame
    void LateUpdate() {
        /*
        if (g.getPathLength() == 0 || /*currentWP == g.getPathLength()*///)
      /*  {
            return;
        }
        /*
        currentNode = g.getPathPoint(currentWP);

        if (Vector3.Distance(g.getPathPoint(currentWP).transform.position, transform.position) < accuracy)
        {
            currentWP++;
        }

        if (currentWP < g.getPathLength())
        {
            goal = g.getPathPoint(currentWP).transform;

            Vector3 lookAtGoal = new Vector3(goal.position.x, this.transform.position.y, goal.position.z);

            Vector3 direction = lookAtGoal - this.transform.position;

            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction),
                                                    Time.deltaTime * rotSpeed);

            this.transform.Translate(0, 0, speed * Time.deltaTime);

        }*/
    }
}
