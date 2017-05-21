using UnityEngine;
using System.Collections;

public class StartAgain2 : MonoBehaviour {

	public float xCoordinates=10;
	
	// Use this for initialization


	public string LevelName;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	private void OnGUI()
	{
		//GUI.backgroundColor = Color.yellow;
		//GUI.contentColor = Color.yellow;

		GUI.color = new Color( 255, 204, 255, 1 );  

		GUIStyle customButton = new GUIStyle("button");
		customButton.fontSize = 25;
		
		//if(GUI.Button(Rect, customButton)) ...

		if(GUI.Button (new Rect (xCoordinates, 30, 250, 150), "PLAY",customButton))
		{
			Application.LoadLevel(LevelName);
			Debug.Log(LevelName);

			//reloadLevel();
		}
		
	}

	public void reloadLevel(){

		Application.LoadLevel(LevelName);
		Debug.Log(LevelName);

	}

	public void creditsScreen(){
		
		Application.LoadLevel("MainSceneStart2");
		
	}

	public void loadBrickLevel(){

		Application.LoadLevel("DestructableWall");

	}

	public void loadBrickLevel2(){
		
		Application.LoadLevel("Destructable2");
		
	}

	public void LoadLevel1(){
		
		Application.LoadLevel("PowerBar");
		
	}

	public void MainsceneSecond(){
		
		Application.LoadLevel("MainSceneSecond");
		
	}

	public void Mainscene2(){
		
		Application.LoadLevel("MainScene2");
		
	}

	public void TwospinningPlanets(){
		
		Application.LoadLevel("TwoSpiningPlanets");
		
	}

	public void MainsceneThree(){
		
		Application.LoadLevel("MainSceneThree");
		
	}

	public void Mainscene4(){
		
		Application.LoadLevel("MainScene4");
		
	}

	public void MainsceneTen(){
		
		Application.LoadLevel("MainSceneTen");
		
	}

	public void MainsceneSecond2(){
		
		Application.LoadLevel("MainSceneSecond2");
		
	}

	public void Mainscene8(){
		
		Application.LoadLevel("MainScene8");
		
	}

	public void Mainscene10(){
		
		Application.LoadLevel("MainScene10");
		
	}

	public void Mainscene15(){
		
		Application.LoadLevel("MainScene 15");
		
	}

	public void Mainscene0(){
		
		Application.LoadLevel("MainSceneStart2");
		
	}
}
