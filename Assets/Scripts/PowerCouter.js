#pragma strict

var Counter: int = 0;
var buttonClick: boolean = false;
var power:int;

function Update () {

           
//power = GameObject.FindWithTag ("SpeedBar").GetComponent<drag> ().value; 


if (Input.GetButtonDown("Fire1"))
		{
			//Counter++;
            //GetComponent.<GUIText>().text="POWER: "+Counter;
		}
		
		//if (Input.GetButton("Fire1"))
		//{
		    if(buttonClick==true){
		    
		    ++Counter;
		    
		    if(Counter<200){
		    
		    GetComponent.<GUIText>().text="POWER: "+Counter + "%";
		    
		    }
			//Debug.Log(Counter);
			//GetComponent.<GUIText>().text="POWER: "+Counter + "%";
		    
		    }
			
			
		//}
		
		//if (Input.GetButtonUp("Fire1"))
		//{
			//Counter=0;
		//}
		
		//if (Input.GetButtonDown("Fire1"))
		//{
		    if(buttonClick==false){
		    
		     Counter=0;
		    
		    }
			
            //GetComponent.<GUIText>().text="PROJECTILES USED: "+Counter;
		//}

}

public function buttonPress(){

		buttonClick = true;
		//Debug.Log(buttonClick);
	}

	public function buttonRelease(){
		
		buttonClick = false;
		//Debug.Log(buttonClick);
	}

