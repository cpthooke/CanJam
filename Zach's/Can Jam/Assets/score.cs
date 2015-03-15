using UnityEngine;
using System.Collections;

public class score : MonoBehaviour {

	public Canvas gameScore;
	GameObject player;

	// Use this for initialization
	void Start () 
	{
		int score = player.GetComponent<GateCheck> ().playerScore;

		gameScore.guiText.text = score + "Gates passed";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
