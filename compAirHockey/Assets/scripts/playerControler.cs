using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControler : MonoBehaviour {
	public GameObject player1;
	public GameObject player2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//move player 2 up
		if (Input.GetKey (KeyCode.W)) {
			player1.GetComponent<Rigidbody>().velocity = new Vector3(0f, 250f, 0f);
		}

		//move player 1 down
		else if (Input.GetKey (KeyCode.S)) {
			player1.GetComponent<Rigidbody>().velocity = new Vector3(0f, -250f, 0f);
		} 

		else {
			player1.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);

		
		}
	}
}
