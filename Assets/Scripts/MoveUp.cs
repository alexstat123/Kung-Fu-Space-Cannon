using UnityEngine;
using System.Collections;

public class MoveUp : MonoBehaviour {
	
	public float Velocity=10;
	public float direction=1;
	public float acceleration;
	int i = 0;
	// Use this for initialization
	
	
	// Update is called once per frame
	void Update () {
		
		i++;
		
		if(i<acceleration){
			
			this.GetComponent<Rigidbody>().AddForce(new Vector3(0,Velocity*direction,0));
			
		}
		
		
	}
}