using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour {

	// Player Movement Variables
	public int MoveSpeed;
	public float JumpHeight;
	private bool doubleJump;

	// Player grounded variables
	public Transform GroundCheck;
	public float GroundCheckRadius;
	public LayerMask whatIsGround;
	private bool Grounded;

	//Non-Stick Player
	private float moveVelocity;


	// Use this for initialization
	void Start () {
		print("Hello World");
	}
	
	void FixedUpdate () {
		Grounded = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, whatIsGround);
	}

	// Update is called once per frame
	void Update () {

		// This code makes the character jump
		if(Input.GetKeyDown (KeyCode.Space)&& Grounded){
			Jump();
		}
		
		// Double Jump Code
		if(grounded)
			doubleJump = false;
	
	
		if(Input.GetKeyDown (KeyCode.Space)&& !doubleJump && !grounded){
			Jump();
			doubleJump = true;
		}
	
		// This code makes the character move from side to side using the A&D keys
		if(Input.GetKey (KeyCode.D)){
			GetComponent<Rigidbody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		
		}
		if(Input.GetKey (KeyCode.A)){
			GetComponent<Rigidbody2D>().velocity = new Vector2(-MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}
	}



	public void Jump(){
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
	}
}
