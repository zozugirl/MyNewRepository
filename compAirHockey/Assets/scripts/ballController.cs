using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballController : MonoBehaviour {
	Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		//left or right
		int xDirection = Random.Range(0,2);
		//up or down
		int yDirection = Random.Range(0,2);

		Vector3 BallDirection = new Vector3();

		//so it goes random on the x-axes
		if (xDirection == 0 ){
			BallDirection.x = -250f;
		}
		if (xDirection == 1 ){
			BallDirection.x = 250f;
		}
		//so it goes random on the y-axes
		if (yDirection == 0 ){
			BallDirection.y = -250f;
		}
		if (yDirection == 1 ){
			BallDirection.y = 250f;
		}


//to make the ball move to the direction the random.range choose
		rb.velocity = BallDirection; 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
