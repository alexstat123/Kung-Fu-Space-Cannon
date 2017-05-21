using UnityEngine;
using System.Collections;

public class LevelController : MonoBehaviour 
{
	public SkinnedMeshRenderer lod0Renderer;
	public SkinnedMeshRenderer lod1Renderer;
	public SkinnedMeshRenderer lod2Renderer;
	
	private int[] lodDistance = new int[3]{ 15, 40, 100};
	private int[] lodTriCount = new int[3]{ 6036, 2536, 1658};
	private int[] lodVertCount = new int[3]{ 3040, 1290, 851};

	private float smooth = 2;
	
	private int _lodIndex = 0;
	private int _zoomIndex = 0;

	private bool guiVisible = true;

	void Start()
	{
		lodIndex = 1;
		zoomIndex = 1;
	}
	
	public int lodIndex
	{
		get
		{
			return _lodIndex;
		}
		
		set
		{
			if(value > 2)
			{
				_lodIndex = 0;
			}
			else if(value < 0)
			{
				_lodIndex = 2;
			}
			else
			{
				_lodIndex = value;
			}

			lod2Renderer.enabled = false;
			lod1Renderer.enabled = false;
			lod0Renderer.enabled = false;
			
			if(_lodIndex == 0)
			{
				lod0Renderer.enabled = true;
			}
			else if(_lodIndex == 1)
			{
				lod1Renderer.enabled = true;;
			}
			else if (_lodIndex == 2)
			{
				lod2Renderer.enabled = true;
			}
		}
	}
	public int zoomIndex
	{
		get
		{
			return _zoomIndex;
		}
		
		set
		{
			_zoomIndex = Mathf.Clamp(value, 0, 2);
			
			lodIndex = zoomIndex;
			
			StopCoroutine("ZoomCamera");
			StartCoroutine("ZoomCamera", lodDistance[zoomIndex]);
		}
	}

	void Update () 
	{		
		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			Application.LoadLevel(Application.loadedLevel);
		}
		if (Input.GetKeyDown (KeyCode.H)) 
		{
			guiVisible = guiVisible == true ? false : true;
		}


		if(Input.GetKeyDown(KeyCode.Minus)||Input.GetKeyDown(KeyCode.Underscore) || (Input.GetAxis("Mouse ScrollWheel") < 0))
		{
			zoomIndex++;
		}
		if(Input.GetKeyDown(KeyCode.Plus)|| Input.GetKeyDown(KeyCode.Equals) || (Input.GetAxis("Mouse ScrollWheel") > 0))
		{
			zoomIndex--;
		}
		
		if(Input.GetKeyDown(","))
		{
			lodIndex--;
		}
		if(Input.GetKeyDown("."))
		{
			lodIndex++;
		}
	}
	
	IEnumerator ZoomCamera(int value)
	{
		while (GetComponent<Camera>().fieldOfView != value) 
		{
			GetComponent<Camera>().fieldOfView = Mathf.Lerp (GetComponent<Camera>().fieldOfView, value, Time.deltaTime * smooth);
			
			yield return null;
		}
	}
	
	void OnGUI() 
	{
		if(guiVisible)
		{
			GUI.Label (new Rect (10, 10, 150, 100), "Rocket Controls:");

			GUI.Label (new Rect (200, 10, 150, 100), "Rotate X Axis: W/S");	
			GUI.Label (new Rect (200, 30, 150, 100), " Rotate Y Axis: A/D");
			GUI.Label (new Rect (200, 50, 150, 100), "Rotate Z Axit: Q/E");
			GUI.Label (new Rect (200, 70, 150, 100), "Thrust: Space");


			GUI.Label (new Rect (10, 110, 200, 100), "Zoom: -/+ or Mouse Wheel");
			GUI.Label (new Rect (200, 110, 150, 100), "Zoom Level: " + (zoomIndex + 1) + "/3");

			GUI.Label (new Rect (10, 150, 150, 100), "Cycle LOD: </>");

			GUI.Label (new Rect (200, 150, 150, 100), "Current LOD: LOD" + lodIndex);
			GUI.Label (new Rect (200, 170, 150, 100), "LOD Tri Count: " + lodTriCount[lodIndex]);
			GUI.Label (new Rect (200, 190, 150, 100), "LOD Tri Count: " + lodVertCount[lodIndex]);	

			GUI.Label (new Rect (10, 220, 150, 100), "Restart: Escape");
			
			GUI.Label (new Rect (10, 260, 150, 100), "Hide GUI: H");
		}
	}
}
