using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextBehavior : MonoBehaviour {

	public bool gameBegan = false;
	public ButtonHandler buttonAction;
	public PlayerControl death;
	public GameObject startButton;
	public GameObject restartButton;

	// Update is called once per frame
	void Update () {
		if (buttonAction.startGame == true) {

			PlayerStatus ();
		}

		if(death.playerDeath){

			DeathText ();
		}

		if (death.playerWin == true){
			VictoryText ();
		}
	}

	void PlayerStatus (){
		Text displayText = this.gameObject.GetComponent<Text>();
		displayText.text = " ";
		startButton.SetActive(false);
	}

	void DeathText(){
		Text displayText = this.gameObject.GetComponent<Text> ();
		displayText.text = "You have died!";
		restartButton.SetActive (true);
	}

	void VictoryText(){
		Text displayText = this.gameObject.GetComponent<Text> ();
		displayText.text = "You have won!";
		restartButton.SetActive (true);
	}
}
