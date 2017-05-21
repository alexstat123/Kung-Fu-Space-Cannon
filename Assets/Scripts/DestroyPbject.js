#pragma strict

var x : int = 0;
public var trackLength:float = 2;
public var destroyWhat:String="Bullet(Clone)";

function Start () {

//Destroy(gameObject,5);

//wait();

}

function Update () {

if (gameObject.name==destroyWhat){
			Destroy(gameObject,trackLength);
		}

}

function wait(){

yield WaitForSeconds(2);

Destroy(gameObject);


}