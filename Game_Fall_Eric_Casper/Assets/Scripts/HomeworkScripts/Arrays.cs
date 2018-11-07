using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour {

	public int[] Eggs = new int[11];
	public string[] Jedi;
	public int[] Feather = new int[5];
	public string[] Witch;
		

	// Use this for initialization
	void Start () {

		Eggs[0] = 1;
		Eggs[1] = 2;
		Eggs[2] = 3;
		Eggs[3] = 4;
		Eggs[4] = 5;
		Eggs[5] = 6;
		Eggs[6] = 7;
		Eggs[7] = 8;
		Eggs[8] = 9;
		Eggs[9] = 10;
		Eggs[10] = 11;
		Eggs[11] = 12;

		print(Eggs[8]);


		Jedi = new string[5];

		Jedi[0] = "Obi Wan Kenobi";
		Jedi[1] = "Yoda";
		Jedi[2] = "Mace Windu";
		Jedi[3] = "Kit Fisto";
		Jedi[4] = "Luke Skywalker";

		foreach(string item in Jedi){
			print("Jedi Master " + item);
		}

		Feather[0] = 1;
		Feather[1] = 2;
		Feather[2] = 3;
		Feather[3] = 4;
		Feather[4] = 5;

		foreach(int item in Feather){
			print(Feather[2]);
		}

		Witch = new string[6];

		Witch[0] = "Grenelda";
		Witch[1] = "Edna";
		Witch[2] = "Beatrice";
		Witch[3] = "Pipo";
		Witch[4] = "Draga";
		Witch[5] = "Rhapsida";

		foreach(string item in Witch){
			print("Welcome fellow witch" + item);
		}
	}

	
	// Update is called once per frame
	void Update () {
		
		// Feathers = new int[5];

		// Feather[0] = 1;
		// Feather[1] = 2;
		// Feather[2] = 3;
		// Feather[3] = 4;
		// Feather[4] = 5;

		// print(Feather[2]);
	}
}
