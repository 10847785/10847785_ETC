using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	public float Speed;
	public Rigidbody2D PC;

	public GameObject EnemyDeath;

	public GameObject ProjectileParticle;

	public int PointsForKill;

	void Start () {
		PC = GameObject.Find("PC").GetComponent<Rigidbody2D>();

		if(PC.transform.localScale.x < 0)
			Speed = -Speed;


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

		Instantiate(ProjectileParticle, transform.position, transform.rotation);
		Destroy (gameObject);
	}



}
