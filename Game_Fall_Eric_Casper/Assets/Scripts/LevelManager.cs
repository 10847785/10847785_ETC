using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject CurrentCheckPoint;
	public Rigidbody2D Player;

	public GameObject Player2;

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
		// player = FindObjectOfType<Rigidbody2D> ();
	}

	public void RespawnPlayer(){
		StartCoroutine ("RespawnPlayerCo");
	}

	public IEnumerator RespawnPlayerCo(){
		//Generate Death Particle
		Instantiate (DeathParticle, Player.transform.position, Player.transform.rotation);
		//Hide Player
		//Player.enabled = false;
		Player2.SetActive(false);
		Player.GetComponent<Renderer> ().enabled = false;
		// Gravity Reset
		GravityStore = Player.GetComponent<Rigidbody2D>().gravityScale;
		Player.GetComponent<Rigidbody2D>().gravityScale = 0f;
		Player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		// Point Penalty
		ScoreManager1.AddPoints(-PointPenatlyOnDeath);
		// Debug Message
		Debug.Log ("Player Respawn");
		//Respawn Delay
		yield return new WaitForSeconds (RespawnDelay);
		//Gravity Restore
		Player.GetComponent<Rigidbody2D>().gravityScale = GravityStore;
		//Match Players transform position
		Player.transform.position = CurrentCheckPoint.transform.position;
		//Show Player
		// Player.enabled = true;
		Player2.SetActive(true);
		Player.GetComponent<Renderer> ().enabled = true;
		//Spawn Particle
		Instantiate (RespawnPartile, CurrentCheckPoint.transform.position, CurrentCheckPoint.transform.rotation);
	}
}
