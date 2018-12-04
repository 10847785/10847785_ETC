using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour {

	// Player Movement Variables
	public int MoveSpeed;
	public float JumpHeight;
	private bool CanDoubleJump;
	public int JumpCount;
	// Sprite Animation
	public Sprite MoveRight;

	// Player Grounded variables
	public Transform GroundCheck;
	public float GroundCheckRadius;
	public LayerMask whatIsGround;
	private bool Grounded;

	//Non-Stick Player
	private float moveVelocity;

	public Animator animator;

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
		if(Input.GetKeyDown(KeyCode.Space) && JumpCount < 1)
		{
			Jump();
			JumpCount++;
			CanDoubleJump = true;
			print("jumping once");
		}

		// Double Jump Code
		if(Grounded){
			print("grounded");
			JumpCount = 0;
		}
	

		
	
		//Non-Stick Player
		moveVelocity = 0f;

		// This code makes the character move from side to side using the A&D keys
		if(Input.GetKey (KeyCode.D)){
			// GetComponent<Rigidbody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			moveVelocity = MoveSpeed;
			// animator.SetFloat("Speed", MoveSpeed);
			GetComponent<SpriteRenderer>().sprite = MoveRight;
			GetComponent<SpriteRenderer>().flipX = false;
		}

		if(Input.GetKey (KeyCode.A)){
			// GetComponent<Rigidbody2D>().velocity = new Vector2(-MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			moveVelocity = -MoveSpeed;
			GetComponent<SpriteRenderer>().flipX = true;

		}
	
		GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);

		//Player flip
		if (GetComponent<Rigidbody2D>().velocity.x > 0)
			transform.localScale = new Vector3(0.2596242f, 0.2662281f, 0.05339174f);

		else if (GetComponent<Rigidbody2D>().velocity.x < 0)
		transform.localScale = new Vector3(-0.2596242f, 0.2662281f, 0.05339174f);
		
	}

	public void Jump(){
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
	}
}
