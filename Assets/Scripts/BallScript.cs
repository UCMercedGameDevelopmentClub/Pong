using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {
	[SerializeField]
	float forceValue = 5f;
	Rigidbody2D ballRB;
	
	// Use this for initialization
	void Start () {
		ballRB = GetComponent<Rigidbody2D>();
		ballRB.AddForce(new Vector2(forceValue * 50,50));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
