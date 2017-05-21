using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {

	// Update is called once per frame
	public void ChangeToScene (string sceneToChangeTo) {

		Application.LoadLevel (sceneToChangeTo);
		Time.timeScale = 1;

	} 

	public void ChangeTo1 () {
		
		Application.LoadLevel ("1st Instructions");

		
	} 
	public void ChangeTo2 () {
		
		Application.LoadLevel ("MainScene");
		
		
	} 

	public void ChangeTo3 () {
		
		Application.LoadLevel ("InstructionWall1");
		
		
	} 

	public void ChangeTo4 () {
		
		Application.LoadLevel ("InstructionWall2");
		
		
	} 

	public void ChangeTo5 () {
		
		Application.LoadLevel ("2st Instructions copy");
		
		
	} 

	public void ChangeTo6 () {
		
		Application.LoadLevel ("4st Instructions copy");
		
		
	} 

	public void ChangeTo7 () {
		
		Application.LoadLevel ("3st Instructions copy");
		
		
	} 

	public void ChangeTo8 () {
		
		Application.LoadLevel ("Instruction4");
		
		
	} 

	public void ChangeTo9 () {
		
		Application.LoadLevel ("MainScene3");
		
		
	} 

	public void ChangeTo10 () {
		
		Application.LoadLevel ("10st Instructions");
		
		
	} 

	public void ChangeTo11 () {
		
		Application.LoadLevel ("11st Instructions");
		
		
	} 

	public void ChangeTo12 () {
		
		Application.LoadLevel ("7st Instructions copy");
		
		
	} 

	public void ChangeTo13 () {
		
		Application.LoadLevel ("13thst Instructions");
		
		
	} 
	
	public void ChangeTo14 () {
		
		Application.LoadLevel ("6st Instructions copy");
		
		
	} 
	
	public void ChangeTo15 () {
		
		Application.LoadLevel ("LastInstructions");
		
		
	} 
}
