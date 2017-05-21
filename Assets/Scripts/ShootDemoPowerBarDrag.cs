using UnityEngine;
using System.Collections;

public class ShootDemoPowerBarDrag: MonoBehaviour
{
	public Rigidbody projectile;
	public float speed = 20;
	float speed2 = 0;
	public bool givePower = false;
	int xx;
	public float acceleration = 1;
	
	
	public drag dragclass;
	
	void start(){
		
		speed2 = 20;
		xx = 0;
	}
	// Update is called once per frame
	void Update ()
	{
		xx = xx + 1;
		//Debug.Log(xx);
		//shootFunction ();
		//if (Input.GetButton("Fire1"))
		//{
		//speed2= Time.deltaTime;
		//Debug.Log(speed2);
		//}
		
	}
	
	
	
	public void shootFunction(){
		
		float power;
		power = GameObject.FindWithTag ("SpeedBar").GetComponent<drag> ().floatvalue;     // was .time
		//Debug.Log(power);
		//if (Input.GetButtonUp("Fire1"))
		//{
		Rigidbody instantiatedProjectile = Instantiate(projectile,transform.position,transform.rotation)as Rigidbody;
		instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0,speed+(power/acceleration),0));  // was just power here not power/30
		
		//speed2=20;
		//}
		
		//if (Input.GetButton("Fire1"))
		//{
		//speed2++;
		
		
		//}
		
		speed2 = 0;
		
		//Debug.Log(power);
		
		
	}
	
	public void power () 
	{
		
		speed2++;
		
		//Debug.Log(speed2);
		
		
	}
	
	public void Enter () 
	{
		
		bool givePower = true;
		//Debug.Log (givePower);
		
	}
	
	public void Exit () 
	{
		
		bool givePower = false;
		//Debug.Log (givePower);
		
	}
	
	
	
	
}