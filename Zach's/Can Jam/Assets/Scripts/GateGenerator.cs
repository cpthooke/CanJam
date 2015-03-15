using UnityEngine;
using System.Collections;

public class GateGenerator : MonoBehaviour 
{
	public float spawnMin = 0f;
	public float spawnMax = 0f;
	public GameObject[] gate;

	// Use this for initialization
	void Start () 
	{
		Invoke ("Spawn", Random.Range (spawnMin, spawnMax));
	}

	void Spawn () 
	{
		int colour;

		colour = Random.Range (0, gate.Length);

		Instantiate (gate [Random.Range (0, gate.Length)], transform.position, Quaternion.identity); //Randomly selects a gate colour
		Invoke ("Spawn", Random.Range (spawnMin, spawnMax)); //Calls the spawn method to generate another gate
	}
}
