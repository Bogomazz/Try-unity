using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviourScript : MonoBehaviour {

	public Vector2 speed = new Vector2 (50, 50);

	private Vector2 movement;
	private Rigidbody2D rgdb2D = new Rigidbody2D();

	// Use this for initialization
	void Start () 
	{
		rgdb2D = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		float inputX = Input.GetAxis ("Horizontal");
		float inputY = Input.GetAxis ("Vertical");

		movement = new Vector2 (
			speed.x * inputX,
			speed.y * inputY
		);
	}

	void FixedUpdate()
	{
		rgdb2D.velocity = movement;
	}
}
