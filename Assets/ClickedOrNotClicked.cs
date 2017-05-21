using UnityEngine;
using System.Collections;

public class ClickedOrNotClicked : MonoBehaviour {

	public bool ClickStatus;

	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseEnter(){

		ClickStatus = true;
		//Debug.Log (ClickStatus);

	}

	void OnMouseExit(){
		
		ClickStatus = false;
		//Debug.Log (ClickStatus);
	}
}
