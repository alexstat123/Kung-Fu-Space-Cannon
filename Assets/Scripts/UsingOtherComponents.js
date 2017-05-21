#pragma strict

public var otherGameObject :  GameObject;


private var anotherScript : AnotherScript;
private var yetAnotherScript :  YetAnotherScript;
private var boxCol : BoxCollider;


function Awake ()
{
    anotherScript = GetComponent(AnotherScript);
    yetAnotherScript = otherGameObject.GetComponent(YetAnotherScript);
    boxCol = otherGameObject.GetComponent(BoxCollider);
}


function Start ()
{
    boxCol.size = new Vector3(3,3,3);
    Debug.Log("The player's score is " + anotherScript.playerScore);
    Debug.Log("The player has died " + yetAnotherScript.numberOfPlayerDeaths + " times");
}