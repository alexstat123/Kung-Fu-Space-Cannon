using UnityEngine;
using System.Collections;

public class TransformFunctions : MonoBehaviour
{

	public float moveSpeed = 40f;
	public float turnSpeed = 50f;
	public int time=0;
	public int P=0;
	public int j=0;
	public bool buttonClick=false;

	void Start()
	{
		buttonClick=false;
	}
	
	void Update ()
	{


		//Debug.Log (time);

		//if (Input.GetButton("Fire1"))
		//{
			
			if(buttonClick==true){

			    j++;
			    
			    //Debug.Log (j);

			if(j<200){


				transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);  // this is the original
				time++;


			}
				//transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);  // this is the original
				//time++;
			}
			 


		//}

		//if (Input.GetButtonUp("Fire1"))
		//{   

			if(buttonClick==false){

			    j =0;  
				transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
				time=0;

			}	 
		


		//}

	}

	public void increasePower(){

		if(Input.GetButton("Fire1")){

			P++;


			//transform.Translate(Vector3.right*1); // remove this to go to original;
			Debug.Log(P);


		}

		if (Input.GetButtonUp("Fire1"))
		{

			P=0;
			Debug.Log(P);
		}



	}

	public void bringPowerToZero(){

		//P = 0;
		//Debug.Log(P);
	}

	public void buttonPress(){

		buttonClick = true;
		Debug.Log(buttonClick);
	}

	public void buttonRelease(){
		
		buttonClick = false;
//		Debug.Log(buttonClick);
	}


}
