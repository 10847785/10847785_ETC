using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject CurrentCheckPoint;
	private Rigidbody2D Player;

	// Particles
	public GameObject DeathParticle;
	public GameObject RespawnPartile;

	//Respawn Delay
	public float RespawnDelay;


	//Point Penalty on Death
	public int PointPenatlyOnDeath;

	// Store Gravity Value
	private float GravityStore;


	// Find Objects by type
	void Start (){
		player = FindObjectOfType<Rigidbody2D> ();
	}

	public void RespawnPlayer(){
		StartCoroutine ("RespawnPlayerCo");
	}

	public IEnumerator RespawnPlayerCo(){
		//Generate Death Particle
		Instantiate (deathParticle, player.transform.position, player.transform.rotation);
		//Hide Player
		//player.enabled = false;
		player.GetComponent<Renderer> ().enabled = false
		// Gravity Reset
		GravityStore = player.GetComponent<Rigidbody2D>().gravityScale
		player.GetComponent<Rigidbody2D>().gravityScale = 0f;
		player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		// Point Penalty
		ScoreManager.AddPoints(-PointPenatlyOnDeath);
		// Debug Message
		Debug.Log ("Player Respawn");
	}
}
