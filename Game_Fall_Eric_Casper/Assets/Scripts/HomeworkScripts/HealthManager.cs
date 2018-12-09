using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour {

	public static int Health;
	// public int GameOver;
	Text HealthText;
	// public Text GameOver;
	

	// Use this for initialization
	void Start () {
		HealthText = GetComponent<Text>();

		Health = 10;
		// HealthText.GetComponent<Text>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Health < 10)
			Health = 10;
		HealthText.text = " " + Health;
	}

	public static void AddHealth (int HealthToAdd) {
		Health += HealthToAdd;
	}
	public void SubHealth (int HealthToSub) {
		Health -= HealthToSub;
	}
}
