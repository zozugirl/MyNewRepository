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
	
	// Update is called once per frame
	void Update () {
		
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
