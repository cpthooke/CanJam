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
		bool inUse = false;

		//do 
		//{
			colour = Random.Range (0, gate.Length);

			if (gate[colour]) //Checks for an instance of the generated colour
				inUse = true;
			else
				Debug.Break ();
				//inUse = false;
		//} 
		//while(inUse = true); //Ensures the same colour is not shown twice on the screen

		Instantiate (gate [Random.Range (0, gate.Length)], transform.position, Quaternion.identity); //Randomly selects a gate colour
		Invoke ("Spawn", Random.Range (spawnMin, spawnMax)); //Calls the spawn method to generate another gate
	}
}
