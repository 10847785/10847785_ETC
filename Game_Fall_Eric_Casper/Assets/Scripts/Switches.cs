using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour {

	public int num;
	public string name;


	// Use this for initialization
	void Start () {
		
	// 	if(num == 10){
	// 		print("Hurray you picked ten!");
	// 	}
		
	// 	else
	// 		print("Boo! You didn't pick ten!");
		

	// 	switch(num){

	// 		case 1:
	// 			print("You picked" + num );
	// 		break;

	// 		case 3:
	// 			print("You picked" + num );
	// 		break;

	// 		case 6:
	// 			print("You picked" + num );
	// 		break;

	// 		case 10:
	// 			print("You picked" + num );
	// 		break;

	// 		default:
	// 			print("I don't understand" + num);
	// 		break;
	// 	}

	switch(name){
		case "Jason":
			print("Welcome to camp crystal lake" + name + " - love mother");
		break;

		case "Michael":
			print("Welcome to Haddonfield, Ill" + name);
		break;

		case "Freddie":
			print("Welcome to Elm Street" = name);
		break;

		case "Leatherface":
			print("The stars and stripes are big at night...Deep in the heart of Texas");
		break;

		default:
			print("I don't know" + name);
		break;
		
	}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
