using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RatioScript : MonoBehaviour {

	public Text t;
	string name = "its me";

	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {

		float r;
		r = GameObject.FindWithTag ("SpeedBar").GetComponent<drag> ().ScreenToPowerBarRatio; 
	
		t.text="Name:" +r;
	}
}
