using UnityEngine;
using System.Collections;

public class WallClick : MonoBehaviour {

	public bool wallClicked;
	// Use this for initialization
	void Start () {
		wallClicked=false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void OnMouseUpAsButton(){
		
		//GravityOn = false;
		wallClicked = false;
		//Debug.Log (wallClicked);
	}

	private void OnMouseDown(){

		wallClicked = true;
		//Debug.Log (wallClicked);

	}
}
