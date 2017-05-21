using UnityEngine;
using System.Collections;

public class FauxGravityAttractorImpulse : MonoBehaviour {
	
	public float gravity =0;
	public int GO=0;
	public int startG = 0;
	public float GravityStartWhen=0;
	public float GravityEndsWhen=0;
	
	public void Attract(Transform body) {
		
		if (GO > startG) {
						Vector3 gravityUp = (body.position - transform.position).normalized;
						Vector3 localUp = body.up;
		
						body.GetComponent<Rigidbody>().AddForce (gravityUp * gravity);
		
						Quaternion targetRotation = Quaternion.FromToRotation (localUp, gravityUp) * body.rotation;
						body.rotation = Quaternion.Slerp (body.rotation, targetRotation, 50f * Time.deltaTime); 
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
