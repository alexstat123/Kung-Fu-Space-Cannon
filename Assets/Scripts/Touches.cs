using UnityEngine;
using System.Collections;

public class Touches : MonoBehaviour {

	public int T=0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		T = Input.touchCount;
		//Debug.Log(T); 
	}
}
