#pragma strict

public var LevelLoadName: String;
public var menu: GameObject;
public var menu2: GameObject;
public var menu3: GameObject;

public var other : GameObject;
private var y:script2;
private var myScore:int;

// instantiate explosion 
public var gameObject4:GameObject;
public var location:Transform;
// instantiate explosion

// Timer variables 
//var x:float=1000;
var startTimer :boolean = false;
var zz:int =0;
public var showStarsTime:float;
public var objectThatTrigersGameOver: String = "bullet";

var countBullets:int;
//Timer variables

function start(){

y =other.GetComponent(script2);
myScore=0;

}

function Update () { 

       countBullets= GameObject.FindWithTag ("NumberOfBalls").GetComponent(Count). Counter;  
       //Debug.Log(countBullets);
        if (Input.GetButtonDown("Fire1"))
		{
		myScore++;                                         // counts number of balls used 
           
        }
        
        
		if(startTimer==true){
		
		 zz=zz+1;
        // Debug.Log(zz);                                    // start timer on impact
		
		}
		
		
		if(zz>showStarsTime){
		
		   if(countBullets==1){                                 // load 3star menue 
		     
		     startTimer=false;                             // set back original conditions
		     zz=0;
		     menu.SetActive(true);
             Time.timeScale=0;
		   
		    }
		
		}
		
		if(zz>showStarsTime){
		
		   if(countBullets==2){                                 // load 2star menue 
		     
		     startTimer=false;                             // set back original conditions
		     zz=0;
		     menu2.SetActive(true);
             Time.timeScale=0;
		   
		   }
		
		 }
		
		if(zz>showStarsTime){
		
		   if(countBullets>=3){                                 // load 1star menue 
		                                                    
		     startTimer=false;                             // set back original conditions
		     zz=0;
		     menu3.SetActive(true);
             Time.timeScale=0;
		   
		   }
		
		}
		
		
}

function OnTriggerEnter(Col:Collider)
{
        
        if(Col.tag == objectThatTrigersGameOver)
             {
             
              startTimer=true;
              //Debug.Log(startTimer); 
              Instantiate (gameObject4,location.position,location.rotation);
               if(myScore==1){
               
                 
                   
                      // menu.SetActive(true);
                       //Time.timeScale=0;
                   
                                          
                      
               
               }
                if(myScore==2){
               
               //-Application.LoadLevel(LevelLoadName);
                       //menu2.SetActive(true);
                       //Time.timeScale=0;
                       //-Debug.Log(ballNumber);
               
               }
                  
              } 
             
}
