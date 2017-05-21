using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class CannonControllerNew : MonoBehaviour,IPointerClickHandler {
	#region IPointerClickHandler implementation
	
	public void OnPointerClick (PointerEventData eventData)
	{
		
		//throw new System.NotImplementedException ();
	}
	
	#endregion
	
	
	private Vector3 mouse_pos;
	private Vector3 object_pos;
	private float angle;
	int x;
	bool button=false; 
	public bool z;
	int TouchCounting;
	public float YMAX=-240;
	public float YMIN=-380;
	public float XMAX=-53;
	public float XMIN=-222;
	public float x1 = 200;
	public float x2 = 400;
	public float maxValx =500;
	public float minValx = 200;
	public float maxValy =500;
	public float minValy = 200;
	
	
	public bool RestraintsOn=true;
	
	// Use this for initialization
	void Start () {
		
		
		TouchCounting = 0;
		button=false;
		
	}
	
	void Update(){
		
		//if(mouse_pos.y>250){transform.rotation = Quaternion.Euler (new Vector3 (0, 0, 90));} // was not here
		
		z = GameObject.FindWithTag ("wall").GetComponent<WallClick> ().wallClicked;
		
		TouchCounting = GameObject.FindWithTag ("TouchManager").GetComponent<Touches> ().T;
		//Debug.Log(TouchCounting); 
		
		//if (TouchCounting==1){
		
		moveCannon ();
		//}
		//if (Input.touchCount==1) {
		
		//moveCannon ();                // here was if(Input.touchCount==1){ moveCannon (); }
		
		//}
		
		//if(RestraintsOn==1){
		
		//distanceToObjectY ();
		//distanceToObjectX ();
		
		//}
		
		
		
		//Debug.Log(sayTrueIfInXandYrange (maxValx, minValx, maxValy, minValy));
		//Debug.Log (XcoordinatesMouse ());
		//Debug.Log (YcoordinatesMouse ());
		//rotateCanonIfInXandYrange(maxValx, minValx, maxValy, minValy);
		
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
		
		//if(TouchCounting==1){
		
		//moveCannon ();
		
		//}
		
	}
	
	
	
	private void moveCannon(){
		
		
		//if( z == true){
			
			
			
			
			mouse_pos = Input.mousePosition;
			mouse_pos.z = 0.0f; 
			
			
			
			object_pos = Camera.main.WorldToScreenPoint (transform.position);
			mouse_pos.x = x+mouse_pos.x - object_pos.x;         // was mouse - object
			mouse_pos.y = mouse_pos.y - object_pos.y;           // was mouse - object
			
			//if(RestraintsOn==true){
				
				//rotatecannonwithparameters();
			//}
			//else{
				
				rotatecannon();
			//}
			
			
			
			
		//}
		
		
		
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
		
		if (deltaY < -YMAX && deltaY > YMIN) {
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
	
	void rotatecannon(){
		
		
		angle = -Mathf.Atan2 (mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg - 90; 
		Vector3 rotationVector = new Vector3 (0, 0, angle);   // WAS 0 in y , it was (0,0,angle), the one that works for cannon (angle+90 , 270, 270)
		transform.rotation = Quaternion.Euler (rotationVector);
		
		
	}
	
	void rotatecannonwithparameters(){
		
		if(distanceToObjectY ()==true && distanceToObjectX()==true){
			rotatecannon();
		}
	}
	
	
	public float XcoordinatesMouse(){
		
		float xcoordinate = Input.mousePosition.x;
		return xcoordinate;
		//Debug.Log (xcoordinate);
	}
	
	public bool sayTrueIfXcoordinatesInRange(float x2, float x1){
		
		bool logic;
		
		if (XcoordinatesMouse ()<x2 && XcoordinatesMouse () > x1) {
			Debug.Log ("True");
			logic =true;
		} else { Debug.Log ("False");
			logic = false;
		}
		
		return logic;
	}
	
	public float YcoordinatesMouse(){
		
		float ycoordinate = Input.mousePosition.y;
		return ycoordinate;
		Debug.Log (ycoordinate);
	}
	
	public bool sayTrueIfYcoordinatesInRange(float y2, float y1){
		
		bool logic2;
		
		if (YcoordinatesMouse ()<y2 && YcoordinatesMouse () > y1) {
			Debug.Log ("True");
			logic2 = true;
		} else { Debug.Log ("False");
			logic2 = false;
		}
		
		return logic2;
	}
	
	public bool sayTrueIfInXandYrange(float maxValx, float minValx, float maxValy, float minValy){
		
		bool logic3;
		
		if(sayTrueIfXcoordinatesInRange(maxValx, minValx)==true && sayTrueIfYcoordinatesInRange(maxValy, minValy)==true){
			
			logic3 = true;
		}
		else {
			
			logic3 = false;
		}
		
		return logic3;
		
	}
	
	void rotateCanonIfInXandYrange(float maxValx, float minValx, float maxValy, float minValy){
		
		if(sayTrueIfInXandYrange(maxValx, minValx, maxValy, minValy)==true){ moveCannon(); }
		
	}
	
	
	
}
