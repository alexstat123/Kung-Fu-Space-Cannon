using UnityEngine;
using System.Collections;

public class RotateCannon2 : MonoBehaviour {
	
	private Vector3 mouse_pos;
	private Vector3 object_pos;
	private float angle;
	int x;
	bool button=false; 
	public bool z;
	int TouchCounting=0;
	public float YMAX=-240;
	public float YMIN=-380;
	public float XMAX=-53;
	public float XMIN=-222;
	
	// Use this for initialization
	void Start () {
		
		button=false;
	}
	
	void Update(){ 
		
		if(mouse_pos.y>250){transform.rotation = Quaternion.Euler (new Vector3 (0, 0, -90));}

		z = GameObject.FindWithTag ("Cylinder").GetComponent<ClickedOrNotClicked> ().ClickStatus;
		//Debug.Log (z);

		TouchCounting = GameObject.FindWithTag ("TouchManager").GetComponent<Touches> ().T;
		//Debug.Log(TouchCounting); 
		
		//if (Input.touchCount==1){
		
		moveCannon ();
		//}
		
		distanceToObjectY ();
		distanceToObjectX ();
		
	}
	
	public void Enter () 
	{
		
		button = true;
		//Debug.Log (button);
		
	}
	
	public void Exit () 
	{
		
		button = false;
		//Debug.Log (button);
		
	}
	
	void FixedUpdate () {  
		
		
		
	}
	
	void moveCannon(){
		
		if (z == true) {
			
			mouse_pos = Input.mousePosition;
			mouse_pos.z = 0.0f; 
			object_pos = Camera.main.WorldToScreenPoint(transform.position);
			mouse_pos.x = mouse_pos.x - object_pos.x;
			mouse_pos.y = mouse_pos.y - object_pos.y;
			
			
			//if(distanceToObjectY ()==true && distanceToObjectX()==true){
				angle = Mathf.Atan2(mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg-270;
				Vector3 rotationVector = new Vector3 (0, 0, angle);
				transform.rotation = Quaternion.Euler(rotationVector);
			//}
		}
		//
	}
	
	public bool distanceToObjectY(){
		bool y;
		float objpos = transform.position.x;
		float mouselocation = Input.mousePosition.x;
		float deltaX = objpos - mouselocation;
		
		float objposy = transform.position.y;
		float mouselocationy = Input.mousePosition.y;
		float deltaY = objposy - mouselocationy;
		//Debug.Log (objpos);
		//Debug.Log (mouselocation);
		//Debug.Log (deltaX);
		//Debug.Log (deltaY);
		
		if (deltaY < YMAX && deltaY > YMIN) {
			y = true;
			//Debug.Log (y);
		} 
		else {
			y= false;
			//Debug.Log (y);
		}
		
		return y;
		
	}
	
	public bool distanceToObjectX(){
		bool x;
		float objpos = transform.position.x;
		float mouselocation = Input.mousePosition.x;
		float deltaX = objpos - mouselocation;
		
		float objposy = transform.position.y;
		float mouselocationy = Input.mousePosition.y;
		float deltaY = objposy - mouselocationy;
		//Debug.Log (objpos);
		//Debug.Log (mouselocation);
		//Debug.Log (deltaX);
		//Debug.Log (deltaY);
		
		if (deltaX < XMAX && deltaX > XMIN) {
			x = true;
			//Debug.Log (x);
		} 
		else {
			x= false;
			//Debug.Log (x);
		}
		
		return x;
		
	}	    
	
}
