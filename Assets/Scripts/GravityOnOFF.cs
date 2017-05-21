using UnityEngine;
using System.Collections;

public class GravityOnOFF : MonoBehaviour {
	
	public float gravity = 0;
	public float GravityAtClick =0;
	public bool GravityOn;
	public bool wasCliked=false;
	public bool GravityOnStart=false;
	
	//public GameObject GO;
	int i = 0;
	int j =0;
	
	public void Attract(Transform body) {
		
		//float j = GO.transform.position.x;
		Vector3 gravityUp = (body.position - transform.position).normalized;
		Vector3 localUp = body.up;
		
		body.GetComponent<Rigidbody>().AddForce(gravityUp * gravity);
		
		Quaternion targetRotation = Quaternion.FromToRotation(localUp,gravityUp) * body.rotation;
		body.rotation = Quaternion.Slerp(body.rotation,targetRotation,50f * Time.deltaTime ); 
	}   
	
	void Start () {
		
		gameObject.GetComponent<Renderer>().material.color = Color.green;
		
		if(GravityOnStart==true){
			
			gravity = GravityAtClick;
			i=1;
		}
		
		
	}
	
	
	void Update ()
	{
		//float j = GO.transform.position.x;
		//Debug.Log(j);
		
		//if(j<0){gravity=80;}
		//if(j<0){gravity=-20;}
		
		//if(j>30){gravity=80;}
		//if(j<30){gravity=0;}
		
		//Debug.Log (i);
		j++;
		Debug.Log (j);

		if(j>=30){
			
			gravity = GravityAtClick;
			gameObject.GetComponent<Renderer>().material.color = Color.red;
			GravityOn=true;
			
			
			//Debug.Log(GravityOn);
		}
		
		if(j<=30){
			
			gameObject.GetComponent<Renderer>().material.color = Color.green;
			gravity = 0;
			GravityOn=true;
			//Debug.Log(GravityOn);
		}

		if(j>=60){

			j=0;

		}
	}
	
	private void OnMouseDown(){
		
		i++;
		
		
		//if(GravityOnStart==true){
		
		//if(i==1){
		
		//gravity = 0;
		//}
		//}
		
		
		if(i%2==1){
			
			gravity = GravityAtClick;
			gameObject.GetComponent<Renderer>().material.color = Color.red;
			GravityOn=true;
			
			
			//Debug.Log(GravityOn);
		}
		
		if(i%2!=1){
			
			gameObject.GetComponent<Renderer>().material.color = Color.green;
			gravity = 0;
			GravityOn=true;
			//Debug.Log(GravityOn);
		}
		
	}
	
	private void OnMouseUpAsButton(){
		
		//GravityOn = false;
		wasCliked = true;
		
	}
	
	
	
}
