using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballController : MonoBehaviour {
	Rigidbody rb;
	// Use this for initialization


	void Start () {
		//shortcut to rigitbodu gameobject
		rb = GetComponent<Rigidbody> ();

		//pause the ball for a little while before it starts to delay the ball from starting moving
		StartCoroutine (Pause ());



	}

	// Update is called once per frame
	void Update () {
		//player1 loses player 2 wins
		if(transform.position.x < -10f){
			StartCoroutine (Pause ());

		}

		//player 2 loses player1 wins
		if(transform.position.x > 866f){
			StartCoroutine (Pause ());

		}
	}
	//to pause the ball for a little bit before it starts
	IEnumerator Pause(){

		yield return new WaitForSeconds (1.5f);
		LaunchBall ();
	}

	void LaunchBall(){
		//to take the ball to the middle again after it goes out and a player wins

		transform.position = new Vector3(423f, 168f, -2f);

		//Direction  ball 2 to go
		//to make it be able to go right, left, right-up, left-up,right-down,left-down.
		//it cant go up and down only because the ball will keep bouncing in the place
		//left or right
		int xDirection = Random.Range(0,2);
		//up or down
		int yDirection = Random.Range(0,3);

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
		if (yDirection == 2) {	
			BallDirection.y = 0f;
		}


		//to make the ball move to the direction the random.range choose
		rb.velocity = BallDirection; 


	}



	void OnCollisionEnter (Collision hit){
		//if ball hits wall it will go the other way not goes back 
		if(hit.gameObject.name =="top_wall"){

			float XDirectionSpeed = 0f;

			if (rb.velocity.x > 0f) {
				XDirectionSpeed = 250f;
			}

			if (rb.velocity.x < 0f) {
				XDirectionSpeed = -250f;
			}

			rb.velocity =new Vector3(XDirectionSpeed, -250f,0f);
		}
		if(hit.gameObject.name =="bottom_wall"){
			float XDirectionSpeed = 0f;

			if (rb.velocity.x > 0f) {
				XDirectionSpeed = 250f;
			}

			if (rb.velocity.x < 0f) {
				XDirectionSpeed = -250f;
			}
			rb.velocity =new Vector3(XDirectionSpeed, 250f,0f);
		}

		//players
		if (hit.gameObject.name == "player1") {
			//default hit will be left
			rb.velocity = new Vector3 (300f, 0f, 0f);


			//to see if we hit lower part so it moves down
			if (transform.position.y - hit.gameObject.transform.position.y < -20) {

				rb.velocity = new Vector3 (250f, -250f, 0f);
			}

			//to see if we hit higher part so it moves back the same way
			if (transform.position.y - hit.gameObject.transform.position.y > 20) {

				rb.velocity = new Vector3 (250f, 250f, 0f);
			}


		}
		//for the 2nd bet same but the x-axes are negative where it was possitive
		if (hit.gameObject.name == "player2") {
			//default hit will be right
			rb.velocity = new Vector3 (-300f, 0f, 0f);


			//to see if we hit lower part so it moves down
			if (transform.position.y - hit.gameObject.transform.position.y < -20) {

				rb.velocity = new Vector3 (-250f, -250f, 0f);
			}

			//to see if we hit higher part so it moves back the same way
			if (transform.position.y - hit.gameObject.transform.position.y > 20) {

				rb.velocity = new Vector3 (-250f, 250f, 0f);
			}


		}

	}


}
