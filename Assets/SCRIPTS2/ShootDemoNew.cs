using UnityEngine;
using System.Collections;

public class ShootDemoNew : MonoBehaviour
{
	public Rigidbody projectile;
	public float speed = 20;
	float speed2 = 0;
	//int Counter=0;
	
	public drag dragclass;
	
	// Update is called once per frame
	private void OnMouseDown()
	{
		//speed2 = dragclass.speed;
		//speed =dragclass.speed+20;
		
		if (Input.GetButtonUp("Fire1"))
		{
			Rigidbody instantiatedProjectile = Instantiate(projectile,transform.position,transform.rotation)as Rigidbody;
			instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0,speed+speed2,0));
			
			speed2=20;
		}
		
		if (Input.GetButton("Fire1"))
		{
			speed2++;
			Debug.Log(speed2);
			
		}
		
	}
}