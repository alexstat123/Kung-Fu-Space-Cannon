using UnityEngine;
using System.Collections;

public class RocketController : MonoBehaviour 
{
	public float thrust = 0.05f;

	public float turn = 0.5f;
	
	//Components
	private Animator animator;

	private Light flameLight;

	private ParticleSystem smoke;

	private ParticleSystem jetFlame;

	private float limitVelocity= 10f;

	void Awake()
	{
		animator = GetComponent<Animator> ();

		flameLight = GetComponentInChildren <Light> ();

		ParticleSystem[] particleSystem = GetComponentsInChildren <ParticleSystem> ();

		smoke = particleSystem[0];

		jetFlame = particleSystem[1];
	}

	void FixedUpdate () 
	{
		if (Input.GetKey (KeyCode.Space)) 
		{
			GetComponent<Rigidbody>().AddRelativeForce (Vector3.up * thrust, ForceMode.Acceleration);

			if(GetComponent<Rigidbody>().velocity.magnitude > limitVelocity)
			{
				GetComponent<Rigidbody>().velocity = Vector3.ClampMagnitude(GetComponent<Rigidbody>().velocity, limitVelocity);
			}

			smoke.enableEmission = true;
			jetFlame.enableEmission = true;

			GetComponent<AudioSource>().volume =  Mathf.Lerp(GetComponent<AudioSource>().volume, 1, (5 * Time.deltaTime));

			if(!GetComponent<AudioSource>().isPlaying)
			{
				GetComponent<AudioSource>().Play();
			}

			flameLight.intensity = Mathf.Lerp(flameLight.intensity, 8, 10 * Time.deltaTime);
		} 
		else
		{
			flameLight.intensity = Random.Range(0.5f,2);
			//flameLight.intensity =  Mathf.Lerp(flameLight.intensity, 0, 10 * Time.deltaTime);

			smoke.enableEmission = false;
			jetFlame.enableEmission = false;

			GetComponent<AudioSource>().volume = Mathf.Lerp(GetComponent<AudioSource>().volume, 0, (5 * Time.deltaTime));
		}

		float velocity = Mathf.Clamp(GetComponent<Rigidbody>().velocity.magnitude, 0, 1);

		if (Input.GetKey (KeyCode.Q)) 
		{
			animator.SetFloat("RudderN",-1,0.5f,2 * Time.deltaTime);
			animator.SetFloat("RudderE",-1,0.5f,2 * Time.deltaTime);
			animator.SetFloat("RudderS",1,0.5f,2 * Time.deltaTime);
			animator.SetFloat("RudderW",1,0.5f,2 * Time.deltaTime);

			GetComponent<Rigidbody>().AddRelativeTorque(Vector3.up * (turn * velocity));
		}
		else if (Input.GetKey (KeyCode.E)) 
		{
			animator.SetFloat("RudderN",1,0.5f,2 * Time.deltaTime);
			animator.SetFloat("RudderE",1,0.5f,2 * Time.deltaTime);
			animator.SetFloat("RudderS",-1,0.5f,2 * Time.deltaTime);
			animator.SetFloat("RudderW",-1,0.5f,2 * Time.deltaTime);

			GetComponent<Rigidbody>().AddRelativeTorque(Vector3.up * (-turn * velocity));
		}
		else
		{
			if (Input.GetKey (KeyCode.A)) 
			{
				animator.SetFloat("RudderN",-1,0.5f,2 * Time.deltaTime);
				animator.SetFloat("RudderS",-1,0.5f,2 * Time.deltaTime);

				GetComponent<Rigidbody>().AddRelativeTorque( 0, 0, (turn * velocity));
			}
			else if (Input.GetKey (KeyCode.D)) 
			{
				animator.SetFloat("RudderN",1,0.5f,2 * Time.deltaTime);
				animator.SetFloat("RudderS",1,0.5f,2 * Time.deltaTime);

				GetComponent<Rigidbody>().AddRelativeTorque( 0, 0, (-turn * velocity));
			}
			else
			{
				animator.SetFloat("RudderN",0,0.5f,2 * Time.deltaTime);
				animator.SetFloat("RudderS",0,0.5f,2 * Time.deltaTime);
			}

			if (Input.GetKey (KeyCode.W)) 
			{
				animator.SetFloat("RudderE",-1,0.5f,2 * Time.deltaTime);
				animator.SetFloat("RudderW",-1,0.5f,2 * Time.deltaTime);

				GetComponent<Rigidbody>().AddRelativeTorque( (turn * velocity), 0, 0);
				
			}
			else if (Input.GetKey (KeyCode.S)) 
			{
				animator.SetFloat("RudderE",1,0.5f,2 * Time.deltaTime);
				animator.SetFloat("RudderW",1,0.5f,2 * Time.deltaTime);

				GetComponent<Rigidbody>().AddRelativeTorque( (-turn * velocity), 0, 0);
			}
			else
			{
				animator.SetFloat("RudderE",0,0.5f,2 * Time.deltaTime);
				animator.SetFloat("RudderW",0,0.5f,2 * Time.deltaTime);
			}
		}
	}
}
