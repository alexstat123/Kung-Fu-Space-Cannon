#pragma strict

function Start () {

}function MoveObject (startPos : Vector3, endPos : Vector3, moveTime : float)
{
    var i = 0.0;
    var rate = 1.0/moveTime;
    while (i < 1.0)
    {
        i += Time.deltaTime * rate;
        transform.position = Vector3.Lerp(startPos, endPos, Mathf.SmoothStep(0.0, 1.0, i));
        yield; 
    }
}

function Update () {


}