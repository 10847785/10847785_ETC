using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoManager : MonoBehaviour {

	public static int Ammo;

	Text AmmoText;

	// Use this for initialization
	void Start () {
		AmmoText = GetComponent<Text>();

		Ammo = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Ammo > 10)
			Ammo = 10;
		AmmoText.text = " " + Ammo;
	}

	public static void AddAmmo (int AmmoToAdd) {
		Ammo += AmmoToAdd;
	}
	public static void SubAmmo (int AmmoToSub) {
		Ammo -= AmmoToSub;
	}
}
