using UnityEngine;
using System.Collections;

public class RemoveCanvas : MonoBehaviour {

	public string LevelLoadName;
	public GameObject menu; // Assign in inspector

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void NoCanvas () {

		menu.SetActive(false);
		Time.timeScale = 1;
		Application.LoadLevel(LevelLoadName);

	
	}

	public void newLevel(){

		Time.timeScale = 1;
		//menu.SetActive(false);
		//Application.LoadLevel("MainScene15");
		Application.LoadLevel(Application.loadedLevel);

	}
}
