using UnityEngine;
using System.Collections;

public class RenderBallisticPath : MonoBehaviour
{

	public float initialVelocity = 10.0f;
	public float timeResolution = 0.02f;
	public float maxTime = 10.0f;


	//////////////////////////////////
	public FauxGravityAttractor attractor;
	private Transform myTransform;
	///////////////////////////////////
	
	private LineRenderer lineRenderer;
	

	void Start ()
	{
		lineRenderer = GetComponent<LineRenderer>();

		GetComponent<Rigidbody>().useGravity = false;
		GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;

		myTransform = transform;
	}
	

	void Update ()
	{
		Vector3 velocityVector = transform.forward*initialVelocity;
		
		lineRenderer.SetVertexCount((int)(maxTime/timeResolution));
		
		int index = 0;
		
		Vector3 currentPosition = transform.position;
		
		for(float t = 0.0f; t < maxTime; t += timeResolution)
		{
			lineRenderer.SetPosition(index,currentPosition);
			

			
			currentPosition += velocityVector*timeResolution;
			//velocityVector += Physics.gravity*timeResolution;  // this determins how line renderer bends
			velocityVector += new Vector3(0,-0.5f,0);
			//if (attractor){
				//attractor.Attract(myTransform);

			//}
			index++;
		}
	}
}
