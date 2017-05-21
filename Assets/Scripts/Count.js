#pragma strict

//public var Counter: int = 0;
var Counter:int;
var x : int;
var y :int;

function Start () {

 Counter=0;
 y = 0;
}

function Update () {

//Debug.Log(Counter);

//if (Input.GetButtonDown("Fire1"))
		//{
			//Counter++;
            //GetComponent.<GUIText>().text="PROJECTILES USED: "+Counter;
            
		//}

    //countBalls(); 
}

function countBalls(){

        //if (Input.GetButtonDown("Fire1"))
		//{
			Counter++;
            GetComponent.<GUIText>().text="PROJECTILES USED: "+Counter;
            
		//}

}

