using UnityEngine;
using System.Collections;

public class GateGenerator : MonoBehaviour {
	
	int colour;
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
		Instantiate (gate [Random.Range (0, gate.Length)], transform.position, Quaternion.identity);
		Invoke ("Spawn", Random.Range (spawnMin, spawnMax));
	}
}
