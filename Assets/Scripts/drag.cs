using UnityEngine;
using System.Collections;

public class drag : MonoBehaviour {
	Vector3 dist;
	Vector3 dist2;
	float posX;
	float posY;
	float posXn;
	Vector3 yVector;
	float posYn;
	float deltaYn;
	int p1;
	float R;
	public float MaxVal = -60;
	public float MinVal = -240;
	public int value=1;
	public int magnitude=1;
	public float floatvalue=384;
	public float subtractor = 0;
	public float ScreenToPowerBarRatio;
	public float speed=0;
	float startingpossition;
	
	void OnMouseDown(){

		dist = Camera.main.WorldToScreenPoint(transform.position);
		//Debug.Log(dist.y);
		posX = Input.mousePosition.x - dist.x;
		posY = Input.mousePosition.y - dist.y;
		//Debug.Log(posY);
		speed = (-posY + 747) / 5;


		//dist2 =Camera.main.ScreenToViewportPoint(transform.position);
		//yVector = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		//posYn = yVector.y;
		//deltaYn = posYn - dist2.y;
       //Debug.Log (deltaYn);


	}

	void start(){

		int p1=0;
		floatvalue=384;
	}
	
	void OnMouseDrag(){

		ScreenToPowerBarRatio = ScreenHeight () / transform.position.y;
		//Debug.Log (ScreenToPowerBarRatio);



			Vector3 curPos = 
			new Vector3(dist.x, Mathf.Clamp((Input.mousePosition.y - posY),MinVal*R,MaxVal*R), dist.z); // dis.x was 45, was ,MinVal,MaxVal
			
		    //Vector3 curPos = 
			//new Vector3(dist.x, Mathf.Clamp((Input.mousePosition.y- posY),startingpossition-73,ScreenHeight()/7.53f), dist.z);

		    //Vector3 curPos = 
			//new Vector3(dist.x, Mathf.Clamp((posYn - deltaYn),0,1), dist.z); // dis.x was 45, was ,MinVal,MaxVal
			
		    //Vector3 curPos = 
			//new Vector3(dist.x, Mathf.Clamp((transform.position.y),MinVal,MaxVal), dist.z);

			Vector3 worldPos = Camera.main.ScreenToWorldPoint(curPos);
		     //Vector3 worldPos = Camera.main.ScreenToViewportPoint(curPos);



			transform.position = worldPos;
		    //Debug.Log (transform.position.y);
		    //Debug.Log (ScreenHeight());
			
		value = (int)(transform.position.y+166)*magnitude;
			


		floatvalue = (transform.position.y+166)*magnitude - subtractor;
	    //Debug.Log (floatvalue);



	}

	void Update(){

		startingpossition = transform.position.y;
		ratioofscreens ();
		//Debug.Log(ratioofscreens ());

		
	}

	float ScreenHeight(){

		float Height = Screen.height;
		return Height;
	}

	float ratioofscreens(){

		R = ScreenHeight ()/600;
		return R;
	}
}




