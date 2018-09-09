using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class AIControlAgent : MonoBehaviour {

    GameObject[] goalLocations;
    public UnityEngine.AI.NavMeshAgent agent;
    Animator anim;
    public float wOffset;
    float speedMultiplier;
    float detectionRadius = 5f;
    float fleeRadius = 10f;

    void ResetAgent()
    {
        speedMultiplier = Random.Range(0.5f, 1.5f);
        agent.speed = 2 * speedMultiplier;
        agent.angularSpeed = 120;
        anim.SetFloat("speedMult", speedMultiplier);
        anim.SetTrigger("isWalking");
        agent.ResetPath();
    }

    public void DetectNewObstacle(Vector3 pos)
    {
        if (Vector3.Distance(pos, this.transform.position) < detectionRadius)
        {
            Vector3 fleeDirection = (this.transform.position - pos).normalized;
            Vector3 newGoal = this.transform.position + (fleeDirection * fleeRadius);

            NavMeshPath path = new NavMeshPath();
            agent.CalculatePath(newGoal, path);

            if (path.status != NavMeshPathStatus.PathInvalid)
            {
                agent.SetDestination(path.corners[path.corners.Length - 1]);
                anim.SetTrigger("isRunning");
                agent.speed = 10;
                agent.angularSpeed = 500;
            }
        }
    }

	// Use this for initialization
	void Start () {
        wOffset = Random.Range(0.1f,1f);
        goalLocations = GameObject.FindGameObjectsWithTag("Goal");
        agent = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.SetDestination(goalLocations[Random.Range(0, goalLocations.Length)].transform.position);
        anim = this.GetComponent<Animator>();
        anim.SetFloat("wOffset", wOffset);
        ResetAgent();
	}
	
	// Update is called once per frame
	void Update () {
        if (agent.remainingDistance < 1)
        {
            ResetAgent();
            agent.SetDestination(goalLocations[Random.Range(0, goalLocations.Length)].transform.position);
        }
	}
}
