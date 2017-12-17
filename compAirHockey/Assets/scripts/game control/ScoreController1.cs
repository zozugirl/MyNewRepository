using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ScoreController1 : MonoBehaviour {
	//make it able to access the ScoreController from the ballController
	public static ScoreController1 instance2;

	public Text player1Scoretext;
	public Text player2Scoretext;

	public int player1Score;
	public int player2Score;

	// Use this for initialization
	void Start () {
		player1Score = player2Score = 0;
		instance2 = this;
	}

	// Update is called once per frame
	void Update () {
	}
	public void GivePlayer1APoint1(){
		player1Score += 1;
		player1Scoretext.text = player1Score.ToString ();
		//enters the next level
		if (player1Score == 5) {

			SceneManager.LoadScene (5);

		}
	}

	public void GivePlayer2APoint1(){
		player2Score += 1;
		player2Scoretext.text = player2Score.ToString ();
		//enters the next level
		if (player2Score == 5) {
			SceneManager.LoadScene (8);


		}


	}

}
