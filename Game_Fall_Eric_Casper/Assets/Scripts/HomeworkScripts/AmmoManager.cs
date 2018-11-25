﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoManager : MonoBehaviour {

	public static int Ammo;

	Text AmmoText;

	// Use this for initialization
	void Start () {
		AmmoText = GetComponent<Text>();

		Ammo = 5;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Ammo > 5)
			Ammo = 5;
		AmmoText.text = " " + Ammo;
	}

	public static void AddAmmo (int AmmoToAdd) {
		Ammo += AmmoToAdd;
	}
}
