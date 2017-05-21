using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody))]
public class FauxGravityBodySpring : MonoBehaviour {
	
	public FauxGravityAttractorSpring attractor;   
	private Transform myTransform;
	
	void Start () {
		GetComponent<Rigidbody>().useGravity = false;
		GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
		
		myTransform = transform;
	}
	
	void FixedUpdate () {
		if (attractor){
			attractor.Attract(myTransform);
		}
	}
	
}