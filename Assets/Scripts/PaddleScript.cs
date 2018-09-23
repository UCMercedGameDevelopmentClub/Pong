using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour {
	[SerializeField]
	bool isPlayerTwo;
	[SerializeField]
	float speed = 0.2f;
	Transform paddleTransform;
	float previousPositionY;
	int direction = 0;
	
	// Use this for initialization
	void Start () {
		paddleTransform = transform;
		previousPositionY = paddleTransform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		
		if(isPlayerTwo == false)
		{
			if(Input.GetKey("w"))
				MoveUp();
			else if(Input.GetKey("s"))
				MoveDown();
		}
		else
		{
			if(Input.GetKey("o"))
				MoveUp();
			else if(Input.GetKey("l"))
				MoveDown();
		}
		if (previousPositionY > paddleTransform.position.y)
			direction = -1;
		else if (previousPositionY < paddleTransform.position.y)
			direction =1;
		else
			direction = 0;
			

		if (paddleTransform.position.y > 2.5f)
            paddleTransform.position = new Vector2(paddleTransform.position.x, 2.5f);
        if (paddleTransform.position.y < -2.5f)
            paddleTransform.position = new Vector2(paddleTransform.position.x, -2.5f);
	}
	
	void MoveUp()
	{
		paddleTransform.position = new Vector2(paddleTransform.position.x,
											paddleTransform.position.y + speed);
	}
	
	void MoveDown()
	{
		paddleTransform.position = new Vector2(paddleTransform.position.x,
											paddleTransform.position.y - speed);
	}

	void LateUpdate()
	{
		previousPositionY = paddleTransform.position.y;
	}


	void OnCollisionExit2D(Collision2D other)
	{
		float adjust = 5 * direction;
		other.rigidbody.velocity = new Vector2(other.rigidbody.velocity.x, other.rigidbody.velocity.y + adjust);        
	}
	
}
