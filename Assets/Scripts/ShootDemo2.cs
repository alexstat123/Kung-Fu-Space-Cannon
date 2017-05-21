using UnityEngine;
using System.Collections;

public class ShootDemo2 : MonoBehaviour
{
	public Rigidbody projectile;
	public float speed = 1;
	float speed2 = 0;
	float Counter=0;
	
	public drag dragclass;
	
	// Update is called once per frame
	void Update ()
	{
		//speed2 = dragclass.speed;
		//speed =dragclass.speed+20;
		
		
		if (Input.GetButtonUp("Fire1"))
		{
			Rigidbody instantiatedProjectile = Instantiate(projectile,transform.position,transform.rotation)as Rigidbody;
			instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0,speed+Counter,0));
			
			speed2=1;
		}
		
		if (Input.GetButton("Fire1"))
		{
			speed2++;
			Counter=speed2/30;
			Debug.Log(speed2);
			
		}
		
		
	}
	
	
	
}