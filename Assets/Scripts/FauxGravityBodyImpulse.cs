using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody))]
public class FauxGravityBodyImpulse : MonoBehaviour {
	
	public FauxGravityAttractorImpulse attractor;
	private Transform myTransform;
	public int GO=0;
	public int startG = 0;

	void Start () {
		GetComponent<Rigidbody>().useGravity = false;
		GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
		
		myTransform = transform;
	}
	
	void FixedUpdate () {

		if (GO > startG) {
						if (attractor) {
								attractor.Attract (myTransform);
						}
				}
	}


	void Update ()
	{
		GO++;
		//float j = GO.transform.position.x;
//		Debug.Log(GO);
		
		//if(j>GravityEndsWhen){gravity=0;}
		//if(j<GravityStartWhen){gravity=-300;} // gravity was 80
		
		
		
	}
	
}
