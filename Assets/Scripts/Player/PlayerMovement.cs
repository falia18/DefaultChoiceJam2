using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed;
	
	// Update is called once per frame
	void Update () {
        // Forward (avancer)
		if(Input.GetKey("w"))
        {
            transform.Translate(new Vector3(0, 0, speed));
        }
        // Left (a gauche)
        if(Input.GetKey("a"))
        {
            transform.Translate(new Vector3(-speed, 0, 0));
        }
        // Down (plus loin(?))
        if(Input.GetKey("s"))
        {
            transform.Translate(new Vector3(0, 0, -speed));
        }
        // Right (a droite)
        if(Input.GetKey("d"))
        {
            transform.Translate(new Vector3(speed, 0, 0));
        }
	}
}
