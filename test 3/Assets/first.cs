using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class first : MonoBehaviour {

	[SerializeField]
	private Text test = null;


	// Use this for initialization
	void Start () {
		test.text = "Unity dungeon press T to start!";
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.T)) {
			test.text = "Hello user, eye am broter eye, eye need you move my sphere, Click the U key to move me";
		}
		if (Input.GetKeyDown (KeyCode.U)) {
			test.text = "My navigation systems are still offline, i can jump across of drop below, what should i do?" +
				"Jump = J" +
				"Drop =D";
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			test.text = "N000 i have fallen and cant get up! you've doomed me!" +
				"Press T to start over";
		}
		if (Input.GetKeyDown (KeyCode.J)) {
			test.text = "Sucess, i've made it across, press A to move forward";
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			test.text = "Oh no its ghost! what should i do?" +
				"F for fight" +
				"H Hope for the best";
		}
		if (Input.GetKeyDown (KeyCode.F)) {
			test.text = "YOU FOOL, you've doomed me! Press T to start over";
		}
		if (Input.GetKeyDown (KeyCode.H)) {
			test.text = "Would you look at that, it vanished! Press W to go forward";
		}
		if (Input.GetKeyDown (KeyCode.W)) {
			test.text = "Oh look its a door! Press O to go into the door";
		}
		if (Input.GetKeyDown (KeyCode.O)) {
			test.text = "Well lets continue this adventure, oh look its an item lets go see what it is. Press I to pick it up";
		}
		if (Input.GetKeyDown (KeyCode.I)) {
			test.text = "I have no idea what this is, hm, should i go through this door or continue on?" +
				"C to continue" +
				"R to go through the door";
		}
		if (Input.GetKeyDown (KeyCode.R)) {
			test.text = "Oh NO! its a reset door! Press T to start over";
		}
		if (Input.GetKeyDown (KeyCode.C)) {
			test.text = "What? a dead end? did we do something wrong? wait let me take a few steps back Press S";
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			test.text = "No this cant be what did we do wrong?...wait the item! press L to use it! ";
		}
		if (Input.GetKeyDown (KeyCode.L)) {
			test.text = "Woah where are we? lets finish this adventure Press Q";
		}
		if (Input.GetKeyDown (KeyCode.Q)) {
			test.text = "There are two doors up ahead...which one should i choose?" +
				"Y For the door on the left" +
				"N For the door on the right ";
		}
		if (Input.GetKeyDown (KeyCode.N)) {
			test.text = "I've made it out of the maze! now i can venture out freely across unity! thank you user! This is the good ending you've made it";
		}
		if (Input.GetKeyDown (KeyCode.Y)) {
			test.text = "What? A new maze? how do i get out, well lets see what we can do! This is the what if ending, play part two to venture throug the dungeon";
		}
	}
}
