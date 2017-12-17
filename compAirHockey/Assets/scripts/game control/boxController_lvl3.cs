using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxController_lvl3 : MonoBehaviour {
	public GameObject box1;
	public GameObject box2;

	// Use this for initialization
	void Start () {
		box1.GetComponent<Rigidbody>().velocity = new Vector3 (0f, 250f, 0f);
		box2.GetComponent<Rigidbody>().velocity = new Vector3 (0f, -250f, 0f);
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
