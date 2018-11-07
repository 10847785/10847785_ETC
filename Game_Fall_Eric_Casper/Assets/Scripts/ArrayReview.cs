using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayReview : MonoBehaviour {

	public string[] Pets;

	// Use this for initialization
	void Start () {
		
		Pets = new string[6];

		Pets[0] = "Dogs";
		Pets[1] = "Cats";
		Pets[2] = "Birds";
		Pets[3] = "Hamsters";
		Pets[4] = "Snakes";
		Pets[5] = "Rocks";

		foreach(string item in Pets){
			print("Here's your pet" + item);
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
