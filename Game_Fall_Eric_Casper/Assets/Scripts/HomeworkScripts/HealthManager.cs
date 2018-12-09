using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour {

	public static int Health;
	public int LoseScore;
	public Text LoseText;
	Text HealthText;
	
	void Awake() {
		Time.timeScale = 1;
	}

	// Use this for initialization
	void Start () {
		HealthText = GetComponent<Text>();

		Health = 2;
		LoseText.GetComponent<Text>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Health < 2)
			Health = 2;
		HealthText.text = " " + Health;

		// If the player win display win test
		if(Health >= LoseScore ){
			print("Game Over =" + Health);
			LoseText.GetComponent<Text>().enabled = true;
			Time.timeScale = 0;
		}
		// If player hits the Escape key return to start menu
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
