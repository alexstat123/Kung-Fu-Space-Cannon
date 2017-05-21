using UnityEngine;
using System.Collections;

public class ShootDemoClick : MonoBehaviour
{
	public Rigidbody projectile;
	public float speed = 20;
	float speed2 = 0;
	public bool y;
	public bool z;
	public bool x;
	//int Counter=0;
	
	public drag dragclass;
	
	// Update is called once per frame
	void Update ()
	{
		//y =GameObject.FindWithTag("planet").GetComponent(FauxGravityAttractorNew).GravityOn;
		y = GameObject.FindWithTag ("planet").GetComponent<FauxGravityAttractorNew> ().GravityOn;
		z = GameObject.FindWithTag ("planet").GetComponent<FauxGravityAttractorNew> ().wasCliked;
		x = GameObject.FindWithTag ("wall").GetComponent<WallClick> ().wallClicked;
		//Debug.Log(x);



		//if(y==false){




			if (Input.GetButtonUp("Fire1"))
			{
				//if(y==false){
				
				Rigidbody instantiatedProjectile = Instantiate(projectile,transform.position,transform.rotation)as Rigidbody;
				instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0,speed+speed2,0));
				
				//}
				
				speed2=20;
			}






		//}









		if (Input.GetButton("Fire1"))
		{
			speed2++;
			//Debug.Log(speed2);
			
		}
		
		
		
		
	}
	
	
	
}