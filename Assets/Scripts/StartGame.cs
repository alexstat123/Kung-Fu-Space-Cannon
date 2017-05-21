using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	private void OnGUI() 
	{
		
		if(GUI.Button (new Rect (100, 0, 200, 100), "START GAME"))
		{
			//Application.LoadLevel("Instruction1");
			startGame();
			
		}
		
	}

	public void startGame(){

		Application.LoadLevel("LevelSelect");


	}

	public void creditsScreen(){

		Application.LoadLevel("Credits");

	}

}