using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour {

	public int num;


	// Use this for initialization
	void Start () {
		
		if(num == 10){
			print("Hurray you picked ten!");
		}
		
		else
			print("Boo! You didn't pick ten!");
		

		switch(num){

			case 1:
				print("You picked" + num );
			break;

			case 3:
				print("You picked" + num );
			break;

			case 6:
				print("You picked" + num );
			break;

			case 10:
				print("You picked" + num );
			break;
			
			default:
				print("I don't understand" + num);
			break;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
