using UnityEngine;
using System.Collections;

public class GUI_Button : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void OnGUI()
	{
		GUIStyle customButton = new GUIStyle("button");
		customButton.fontSize = 25;

		if(GUI.Button (new Rect (1020, 30, 250, 150), "End Game",customButton))  // third value was 150
		{
			Application.Quit(); 

		}

	}

	public void endGame(){

		Application.Quit(); 

	}

}
