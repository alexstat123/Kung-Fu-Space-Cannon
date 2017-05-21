using UnityEngine;
using System.Collections;

public class AsteroidFieldGenerator : MonoBehaviour 
{
	public GameObject[] asteroidPrefab;

	public float fieldRadius;

	void Start ()
	{
		for(int i = 0; i < 100; ++i)
		{
			GameObject newAsteroid = (GameObject)Instantiate(asteroidPrefab[Random.Range(0, asteroidPrefab.Length)], Random.insideUnitSphere * fieldRadius, Random.rotation);

			newAsteroid.transform.parent = transform;

			float size = Random.Range(0.1f, 5);

			newAsteroid.transform.localScale = Vector3.one * size;
		}
	}
}
