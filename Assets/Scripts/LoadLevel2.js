#pragma strict
function OnTriggerEnter(Col:Collider)
{
 if(Col.tag == "bullet")
 {
 Application.LoadLevel("MainScene3");
 
 } 

}