using UnityEngine;
using System.Collections;

public class PowerBarPosition : MonoBehaviour {

	public float screenwidthRatio;
	public float screenheigthRatio;
	public float zbar = 50;




	// Use this for initialization
	void Start () {
	


	}
	
	// Update is called once per frame
	void Update () {
	



		Vector3 worldPos = Camera.main.ScreenToWorldPoint (new Vector3 (Screen.width * screenwidthRatio, Screen.width*screenheigthRatio, zbar));  // x was 230
		transform.position = worldPos;    // y was 300;
	}


	
	
	

}


