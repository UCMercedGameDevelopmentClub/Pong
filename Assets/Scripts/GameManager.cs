using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	[SerializeField]
	int pointsToWin = 5;	//so we can dynamicly set how many points is needed to win

	public int player1Points = 0;	//this keeps tracks of points for both players
	public int player2Points = 0;

	GameObject player1;
	GameObject player2;
	GameObject ball;
	// Use this for initialization
	void Start () {
		player1 = GameObject.Find("player1");
		player2 = GameObject.Find("player2");
		ball = GameObject.Find("ball");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// this function will take in the player's number when they score
	public void playerScored(int playerNumber){

		if(playerNumber == 1){ 				//if player 1, add 1 point to their score, then check if they won
			player1Points++;
			if(player1Points >= pointsToWin)
				ResetGame();
		}
		if(playerNumber == 2){
			player2Points++;
			if(player2Points >= pointsToWin)
				ResetGame();
		}
		ResetRound();						//return the gameobjects to their original position...
	}

	// move everything back to starting position...
	void ResetRound(){
		ball.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
        ball.GetComponent<Rigidbody2D>().AddForce(new Vector2(4.5f * 50,50));
		ball.transform.position = new Vector2(0f,0f);
		player1.transform.position = new Vector2(-3.5f,0f);
		player2.transform.position = new Vector2(3.5f,0f);
	}

	void ResetGame(){
		player1Points = 0;
		player2Points = 0;
		ResetRound();
	}
		
	
}
