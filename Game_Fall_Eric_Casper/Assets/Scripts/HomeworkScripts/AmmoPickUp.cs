using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickUp : MonoBehaviour {

	public int AmmoToAdd;

	void OnTriggerEnter2D (Collider2D Other){
		if (Other.GetComponent<Rigidbody2D> () == null)
			return;
		AmmoManager.AddAmmo (AmmoToAdd);

	Destroy (gameObject);
	}
}
