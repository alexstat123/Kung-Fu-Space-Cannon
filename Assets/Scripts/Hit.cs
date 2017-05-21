using UnityEngine;
using System.Collections;

public class Hit : MonoBehaviour {

	public string GameOverSceenName;
	public GameObject menu;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnParticleCollision(GameObject other){


     	Debug.Log("Particle hit!");
		Application.LoadLevel(GameOverSceenName);

		//menu.SetActive(true);

		//Time.timeScale=0;
	}
}
