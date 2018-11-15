using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickUp : MonoBehaviour {

	public int HealthToAdd;

	void OnTriggerEnter2D (Collider2D Other){
		if (Other.GetComponent<Rigidbody2D> () == null)
			return;
		HealthManager.AddHealth (HealthToAdd);

	Destroy (gameObject);
	}
}
