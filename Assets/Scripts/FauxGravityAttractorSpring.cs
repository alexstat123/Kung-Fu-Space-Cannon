using UnityEngine;
using System.Collections;

public class FauxGravityAttractorSpring : MonoBehaviour {
	
	public float gravity = -12;
	public GameObject Projectille;
	public float GravityZeroWhen=0;
	//public float GravityEndsWhen=0;
	
	public void Attract(Transform body) {
		
		//float j = Projectille.transform.position.x;
		Vector3 gravityUp = (body.position - transform.position).normalized;
		Vector3 localUp = body.up;
		
		body.GetComponent<Rigidbody>().AddForce(gravityUp * gravity);
		
		Quaternion targetRotation = Quaternion.FromToRotation(localUp,gravityUp) * body.rotation;
		body.rotation = Quaternion.Slerp(body.rotation,targetRotation,50f * Time.deltaTime ); 
	}   
	
	void Update ()
	{
		//float j = Projectille.transform.position.x;
		//Debug.Log(j);


		//if(j<GravityZeroWhen){gravity=0;}
		//if(j<GravityStartWhen){gravity=-80;}
		
		
		
	}
	
	
}