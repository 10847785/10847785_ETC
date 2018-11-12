using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {
	// Shoot Variables
	public Transform FirePoint;
	public GameObject Projectile;

	void Start(){
		Projectile = Resources.Load("PreFab/Projectile") as GameObject;
	}
	
	// Able to shoot
	void Update () {
		if(Input.GetKeyDown(KeyCode.RightControl))
			Instantiate(Projectile,FirePoint.position, FirePoint.rotation);

	}
}
