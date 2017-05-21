using UnityEngine;
using System.Collections;

public class ButtonVisibility : MonoBehaviour {

	public GameObject buttonlevel;
	public GameObject buttonlevel3;
	public GameObject buttonlevel4;
	public GameObject buttonlevel5;
	public GameObject buttonlevel6;
	public GameObject buttonlevel7;
	public GameObject buttonlevel8;
	public GameObject buttonlevel9;
	public GameObject buttonlevel10;
	public GameObject buttonlevel11;
	public GameObject buttonlevel12;
	public GameObject buttonlevel13;
	public GameObject buttonlevel14;
	public GameObject buttonlevel15;

	public GameObject QuestionMark;
	public GameObject QuestionMark3;
	public GameObject QuestionMark4;
	public GameObject QuestionMark5;
	public GameObject QuestionMark6;
	public GameObject QuestionMark7;
	public GameObject QuestionMark8;
	public GameObject QuestionMark9;
	public GameObject QuestionMark10;
	public GameObject QuestionMark11;
	public GameObject QuestionMark12;
	public GameObject QuestionMark13;
	public GameObject QuestionMark14;
	public GameObject QuestionMark15;


	// Use this for initialization
	void Start () {

		if (PlayerPrefs.GetInt ("UnlockLevel2d") == 1) {

			buttonlevel.SetActive (true); 
			QuestionMark.SetActive(false);
		}

		if (PlayerPrefs.GetInt ("UnlockLevel3d") == 1) {
			
			buttonlevel3.SetActive (true);
			QuestionMark3.SetActive(false);
		}

		if (PlayerPrefs.GetInt ("UnlockLevel4d") == 1) {
			
			buttonlevel4.SetActive (true);
			QuestionMark4.SetActive(false);
		}

		if (PlayerPrefs.GetInt ("UnlockLevel5d") == 1) {
			
			buttonlevel5.SetActive (true);
			QuestionMark5.SetActive(false);
		}

		if (PlayerPrefs.GetInt ("UnlockLevel6d") == 1) {
			
			buttonlevel6.SetActive (true);
			QuestionMark6.SetActive(false);
		}
		
		if (PlayerPrefs.GetInt ("UnlockLevel7d") == 1) {
			
			buttonlevel7.SetActive (true);
			QuestionMark7.SetActive(false);
		}
		
		if (PlayerPrefs.GetInt ("UnlockLevel8d") == 1) {
			
			buttonlevel8.SetActive (true);
			QuestionMark8.SetActive(false);
		}
		
		if (PlayerPrefs.GetInt ("UnlockLevel9d") == 1) {
			
			buttonlevel9.SetActive (true);
			QuestionMark9.SetActive(false);
		}

		if (PlayerPrefs.GetInt ("UnlockLevel10d") == 1) {
			
			buttonlevel10.SetActive (true);
			QuestionMark10.SetActive(false);
		}
		
		if (PlayerPrefs.GetInt ("UnlockLevel11d") == 1) {
			
			buttonlevel11.SetActive (true);
			QuestionMark11.SetActive(false);
		}
		
		if (PlayerPrefs.GetInt ("UnlockLevel12e") == 1) {
			
			buttonlevel12.SetActive (true);
			QuestionMark12.SetActive(false);
		}

		if (PlayerPrefs.GetInt ("UnlockLevel13d") == 1) {
			
			buttonlevel13.SetActive (true);
			QuestionMark13.SetActive(false);
		}
		
		if (PlayerPrefs.GetInt ("UnlockLevel14d") == 1) {
			
			buttonlevel14.SetActive (true);
			QuestionMark14.SetActive(false);
		}
		
		if (PlayerPrefs.GetInt ("UnlockLevel15d") == 1) {
			
			buttonlevel15.SetActive (true);
			QuestionMark15.SetActive(false);
		}
	

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
