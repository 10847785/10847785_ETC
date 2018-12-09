using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour {

	public static int Health;
	public int GameOver;
	Text HealthText;
	public Text LoseText;
	
	void Awake(){
		Time.timeScale = 1;
	}

	// Use this for initialization
	void Start () {
		HealthText = GetComponent<Text>();

		Health = 0;
		HealthText.GetComponent<Text>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Health > 0)
			Health = 0;
		HealthText.text = " " + Health;

	// If player loses it's game over screen for you
		if(Health >= GameOver ){
			print("Lost all lives =" + Health);
			HealthText.GetComponent<Text>().enabled = true;
			Time.timeScale = 0;
		}
	// If player hits escape key they return to main menu
		if(Input.GetKeyDown(KeyCode.Escape)){
			SceneManager.LoadScene(0);
		}
	}

	public static void AddHealth (int HealthToAdd) {
		Health += HealthToAdd;
	}
	public void SubHealth (int HealthToSub) {
		Health -= HealthToSub;
	}
}
