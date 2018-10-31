using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour {

	public int num;
	public string objectName;
	public int spell;
	public string room;
	public bool lights;


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

	switch(objectName){
		case "Jason":
			print("Welcome to camp crystal lake" + objectName + " - love mother");
		break;

		case "Michael":
			print("Welcome to Haddonfield, Ill" + objectName);
		break;

		case "Freddie":
			print("Welcome to Elm Street" + objectName);
		break;

		case "Leatherface":
			print("The stars and stripes are big at night...Deep in the heart of Texas");
		break;

		default:
			print("I don't know" + objectName);
		break;

	}
	switch(spell){
		case 1:
			print("Alicazam");
		break;
		
		case 2:
			print("Double Maxous");
		break;

		case 3:
			print("Open says me");
		break;

		case 5:
			print("Abracadabra");
		break;

		case 7:
			print("Shamalama Ding Dong");
		break;

		case 9:
			print("Lichromenta");
		break;

		case 10:
			print("Pomdoda");
		break;

		default:
			print("I don't know" + spell);
		break;
	}

		switch(room){
			case "Yard":
				print("You are entering the yard.");
			break;

			case "House":
				print("Welcome home!");
			break;

			case "Woods":
				print("You are entering the woods.");
			break;

			default:
				print("I don't know this room");
			break;
		}

		if(lights == true){
			print("You have a light");
		}
		else
			print("What light?");

		switch(lights){
			case true:
				print("This is lighted" + lights);
			break;

			default:
				print("Light is broken");
			break;
			
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
