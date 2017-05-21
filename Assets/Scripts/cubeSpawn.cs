using UnityEngine;
using System.Collections;

public class cubeSpawn : MonoBehaviour {
	
	int counter=0;
	public int speed=1;
	public int numberOfObjects = 200;
	public float xMin, xMax, yMin, yMax;
	
	public GameObject cubePrefabVariable;
	public GameObject spherePrefabVariable;
	// Use this for initialization
	void Start () {
		
		Instantiate (cubePrefabVariable);
		//Instantiate (spherePrefabVariable);
		
	}
	
	// Update is called once per frame
	void Update () { 
		
		counter++;
		
		if(counter<numberOfObjects){
			
			
			if(counter%speed==0){ 
				
				Instantiate (cubePrefabVariable);
				
				
				//Instantiate (spherePrefabVariable);
			}
			
			
		}
		
		
		
	}
}
