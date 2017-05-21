using UnityEngine;
using System.Collections;

public class MenuCanvas : MonoBehaviour {
	
	public Canvas Canvasorg;
	public Canvas MainMenuCanvas;
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown (KeyCode.Escape)){
			if(MainMenuCanvas.enabled == true){
				
				Canvasorg.enabled = true;
				MainMenuCanvas.enabled = false;
				
			} else {
				
				Canvasorg.enabled = false;
				MainMenuCanvas.enabled = true;
				
			}
		}
	}
}