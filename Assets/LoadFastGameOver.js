#pragma strict

public var menu: GameObject;
public var gameoverobject:String = "bullet";
public var y:int;

function Start () {

}

function Update () {

y =GameObject.FindWithTag("target1").GetComponent(LoadLevel).zz;

}

function OnTriggerEnter(Col:Collider){

if(y==0){

var logic1:boolean;
if(Col.tag == gameoverobject){
logic1=true;
Debug.Log (logic1);
menu.SetActive(true);
Time.timeScale=0;


}



}

}





