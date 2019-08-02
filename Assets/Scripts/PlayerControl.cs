using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
	
	public Rigidbody2D rbody;
	public ButtonHandler buttonAction;
	public TextBehavior textScript;
	public bool playerDeath = false;
	public bool playerWin = false;

	void Start(){
		rbody.bodyType = RigidbodyType2D.Kinematic;
	}

	// Update is called once per frame
	void Update () {
		if(buttonAction.startGame == true){
			rbody.bodyType = RigidbodyType2D.Dynamic;
			PlayerMovement();
			PlayerInput();
		}

		if (playerWin == true) {
			rbody.bodyType = RigidbodyType2D.Kinematic;
		}
	}

	void PlayerInput(){
		if (Input.GetKey (KeyCode.Space)) {
			rbody.AddForce (Vector2.up * 50);
		}
	}

	void PlayerMovement (){
		rbody.AddForce (Vector2.right * 50 * Time.deltaTime);
	}

	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "Danger") {
			playerDeath = true;
			Destroy (rbody);
		} else if (collision.gameObject.tag == "Victory") {
			playerWin = true;

		}
	}
}
