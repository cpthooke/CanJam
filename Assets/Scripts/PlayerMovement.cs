using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{
	Vector3 playerPosition;
	public float moveSpeed;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		playerPosition = this.transform.position;
		playerPosition.x += moveSpeed;
		this.transform.position = playerPosition;
	}
}
