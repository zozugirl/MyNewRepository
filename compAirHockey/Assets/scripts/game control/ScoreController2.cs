using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ScoreController2 : MonoBehaviour {
	//make it able to access the ScoreController from the ballController
	public static ScoreController2 instance3;

	public Text player1Scoretext;
	public Text player2Scoretext;

	public int player1Score;
	public int player2Score;

	// Use this for initialization
	void Start () {
		player1Score = player2Score = 0;
		instance3 = this;
	}

	// Update is called once per frame
	void Update () {
	}
	public void GivePlayer1APoint2(){
		player1Score += 1;
		player1Scoretext.text = player1Score.ToString ();
		//enters the next level
		if (player1Score == 5) {

			SceneManager.LoadScene (6);

		}
	}

	public void GivePlayer2APoint2(){
		player2Score += 1;
		player2Scoretext.text = player2Score.ToString ();
		//enters the next level
		if (player2Score == 5) {
			SceneManager.LoadScene (9);


		}


	}

}
