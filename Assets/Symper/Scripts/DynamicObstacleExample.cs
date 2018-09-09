using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Input;

public class DynamicObstacleExample : MonoBehaviour {

    bool open = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("f"))
        {
            if (open)
                this.transform.Translate(0,- 4, 0);
            else
                this.transform.Translate(0,4,0);

            open = !open;

            Debug.Log(open);

        }
	}
}
