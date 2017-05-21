using UnityEngine;
using System.Collections;

public class RotateItem : MonoBehaviour {

	//public int RotateSpeed = 1;
	public int x=0;
	public int y=0;
	public int z=0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (Time.deltaTime*x, Time.deltaTime*y, Time.deltaTime*z));
	}
}
