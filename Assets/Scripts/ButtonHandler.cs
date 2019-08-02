using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour {

	public Button startButton;
	public Button resetButton;
	public bool startGame = false;
	public bool restartGame = false;

	// Use this for initialization
	void Start () {

		Button sButton = startButton.GetComponent<Button> ();
		sButton.onClick.AddListener (StartGame);
		Button rButton = resetButton.GetComponent<Button> ();
		rButton.onClick.AddListener (Restart);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void StartGame(){
		startGame = true;
	}

	public void Restart(){
		SceneManager.LoadScene ("Scene_1");
	}
}
