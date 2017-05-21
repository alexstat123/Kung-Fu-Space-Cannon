using UnityEngine;
using System.Collections;

public class MenuAppearScript : MonoBehaviour {
	
	public GameObject menu; // Assign in inspector
	public GameObject menu2; // Assign in inspector
	public GameObject menu3; // Assign in inspector
	private bool isShowing;
	private bool isShowing2;
	private bool isShowing3;
	
	void Update() {
		if (Input.GetKeyDown("escape")) {
			isShowing = !isShowing;
			menu.SetActive(isShowing);


	}

		if (Input.GetKeyDown("space")) {
			isShowing2 = !isShowing2;
			menu2.SetActive(isShowing2); 
		}

		if (Input.GetKeyDown("backspace")) {
			isShowing3 = !isShowing3;
			menu3.SetActive(isShowing3); 
		}
 }
}
