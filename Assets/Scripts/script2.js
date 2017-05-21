#pragma strict
public var otherGameObject : GameObject;
public var other : GameObject;
private var x:script1;
private var y:Count;
public var z: int;

function Start () {

x =otherGameObject.GetComponent(script1);
y =other.GetComponent(Count);


}

function Update () {

z = y.Counter;
Debug.Log(x.x);
//Debug.Log(z);

}