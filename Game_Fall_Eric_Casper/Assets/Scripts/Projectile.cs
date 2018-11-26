using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	public float Speed;

	public GameObject PC;

	public GameObject EnemyDeath;

	public GameObject ProjectileParticle;

	public int PointsForKill;

	public int TimeOut;

	public GameObject AmmoPickUp;

	void Start () {
		PC = GameObject.Find("PC");

		EnemyDeath = Resources.Load("PreFab/DeathParticle") as GameObject;
		ProjectileParticle = Resources.Load("PreFab/Projectile") as GameObject;
		

		if(PC.transform.localScale.x < 0)
			Speed = -Speed;
	
	Destroy (gameObject, TimeOut);

	}

	void Update () {
		GetComponent<Rigidbody2D>().velocity = new Vector2(Speed, GetComponent<Rigidbody2D>().velocity.y);
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Enemy"){
			Instantiate(EnemyDeath, other.transform.position, other.transform.rotation);
			Destroy (other.gameObject);
			ScoreManager1.AddPoints (PointsForKill);
		}

		
		Destroy (gameObject);
	}

	void OnCollisionEnter2D(Collision2D other){
		if(other.gameObject.tag == null){
		Instantiate(ProjectileParticle, transform.position, transform.rotation);
		Destroy (gameObject);
		}
		else if(other.gameObject.tag == "Player"){
			print("Hit player");
		}
	}

	// void OnTriggerEnter2D(Collider2D other){
	// 	if(other.tag == "PC"){
	// 		Instantiate(AmmoPickUp, other.transform.position, other.transform.rotation);
	// 		Destroy (other.gameObject);
	// 		AmmoManager.AddAmmo (AmmoToAdd);
	// 	}
	// }


}
