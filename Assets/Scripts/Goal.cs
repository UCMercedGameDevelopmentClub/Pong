using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

	[SerializeField]
	int playerNumber;

	GameManager gmScript;	//we'll use this to reference the GameManager

	// Use this for initialization
	void Start () {
		//find the GameManager object and get the script called "GameManager" inside
		gmScript = GameObject.Find("GameManager").GetComponent<GameManager>();
	}
	
	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.transform.name == "ball") //check if the other object is the ball
			gmScript.playerScored(playerNumber);	//give points
	} 
}
