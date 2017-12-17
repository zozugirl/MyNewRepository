using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreController : MonoBehaviour {
	//make it able to access the ScoreController from the ballController
	public static ScoreController instance;

	public Text player1Scoretext;
	public Text player2Scoretext;

	public int player1Score;
	public int player2Score;

	// Use this for initialization
	void Start () {
		player1Score = player2Score = 0;
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {
	}
	public void GivePlayer1APoint(){
		player1Score += 1;
		player1Scoretext.text = player1Score.ToString ();

	}

	public void GivePlayer2APoint(){
		player2Score += 1;
		player2Scoretext.text = player2Score.ToString ();
	
	}

}
