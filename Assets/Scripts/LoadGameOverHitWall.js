#pragma strict
public var GameOverSceenName: String;
function OnTriggerEnter(Col:Collider)
{

 if(Col.tag == "Planet2")
 {
 Application.LoadLevel(GameOverSceenName);
 
 } 

}