#pragma strict
public var locationY: float;
function Start () {

}

function Update () {

if (Input.GetButtonUp("Fire1"))
		{
			transform.position.x= locationY; // was y
		}
		
		
 
}