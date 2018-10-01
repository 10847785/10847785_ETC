using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup1 : MonoBehaviour {

	public int PointsToAdd

	 void OnTriggerEnter2D (Collider2D Other){
		if (Other.GetComponent<Rigidbody2D> () == null)
			return;
	

	ScoreManager.AddPoints (PointsToAdd);

	Destroy (gameObject);
	}
}
