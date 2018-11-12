using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour {

	public int[] Eggs = new int[11];
	public string[] Jedi;
	public int[] Feather = new int[5];
	public string[] Witch;
	public int[] Water = new int[6];
	public string[] Townspeople;
	public int[] Twigs =  new int[6];
		

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

		Water[0] = 1;
		Water[1] = 2;
		Water[2] = 3;
		Water[3] = 4;
		Water[4] = 5;
		Water[5] = 6;

		foreach(int item in Water){
			print(Water[3]);
		}

		Townspeople = new string[6];

		Townspeople[0] = "It's her!";
		Townspeople[1] = "Burn the witch!";
		Townspeople[2] = "Witch, Witch!";
		Townspeople[3] = "Get her!";
		Townspeople[4] = "Run!";
		Townspeople[5] = "There you are!";

		foreach(string item in Townspeople){
			print("You have been spotted.");
		}
		
		Twigs[0] = 1;
		Twigs[1] = 2;
		Twigs[2] = 3;
		Twigs[3] = 4;
		Twigs[4] = 5;
		Twigs[5] = 6;

		foreach(int item in Twigs){
			print(Twigs[5]);
		}



	}

	
	// Update is called once per frame
	void Update () {
	}
}
