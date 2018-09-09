using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropAvoidant : MonoBehaviour {

    // Use this for initialization
    public GameObject obstacle;
    GameObject[] agents; 

	void Start () {
        agents = GameObject.FindGameObjectsWithTag("aiAgent");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray.origin, ray.direction, out hitInfo))
            {
                Instantiate(obstacle, hitInfo.point, obstacle.transform.rotation);
                foreach (GameObject a in agents)
                {
                    a.GetComponent<AIControlAgent>().DetectNewObstacle(hitInfo.point);
                }
            }
        }
	}
}
