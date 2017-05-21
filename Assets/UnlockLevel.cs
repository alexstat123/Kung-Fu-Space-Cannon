using UnityEngine;
using System.Collections;



public class UnlockLevel : MonoBehaviour {

	//public string unlockname;

	// Use this for initialization
	void Start () {

		PlayerPrefs.SetInt ("UnlockLevel2d", 1);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
