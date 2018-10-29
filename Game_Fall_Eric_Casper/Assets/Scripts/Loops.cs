using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour {

	public int Num = 40;
	
	public string Color = "Blue";

	// Use this for initialization
	void Start () {
		// for(int i=0; i <= 100; i++){

		// 	print(i + " Ants Marching");

		// }
		
		// while(Num > 0){
		// 	print("Countdown" + Num);
		// 	Num --;
		// }

		for(int i=6; i <= 16; i++){
			print(i + "Raining");
		}

		while(Num < 16){
			print("The rain is gone" + Num);
			Num --;
		}

		// for(int i=5; i <= 1++){
		// 	print(i + "Sky is Falling");
		// }
		// while(Num > 5){
		// 	print(i + "It's over" + Num);
		// 	Num ++;
		// }
		
		}
	}
	
	// Update is called once per frame
	// void Update () {
		
	// }

