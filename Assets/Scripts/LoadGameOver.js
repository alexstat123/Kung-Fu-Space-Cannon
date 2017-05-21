#pragma strict

public var GameOverSceenName: String;
public var y:int;


function Start () {



}

function Update () {


y =GameObject.FindWithTag("target1").GetComponent(LoadLevel).zz;
//Debug.Log(y);

}


function OnTriggerEnter(Col:Collider)
{

 if(Col.tag == "bullet")
 {
          if(y==0){
          
          Application.LoadLevel(GameOverSceenName);
          
          }
          
 
 } 

}
