using UnityEngine;
using System.Collections;

public class MoveByItselfY2 : MonoBehaviour {
	
	public float Velocity=10;
	public float direction=1;
	
	int i = 0;
	// Use this for initialization
	
	
	// Update is called once per frame
	void Update () {
		
		i++;
		
		if(i<10){
			
			this.GetComponent<Rigidbody>().AddForce(new Vector3(0,Velocity*direction,0));
			
		}
		
		
	}
}