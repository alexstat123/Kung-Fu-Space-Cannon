using UnityEngine;
using System.Collections;

public class Instantiation : MonoBehaviour {

	public GameObject gameObject4;
	public Transform location;

	// Use this for initialization
	void Start () {


		Instantiate (gameObject4,location.position,location.rotation);
	}
	
	// Update is called once per frame
	void Update () { 
	
	}
}
