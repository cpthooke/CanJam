using UnityEngine;
using System.Collections;

public class gameInterface : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.GetButton ("FireG")) && (Input.GetAxis ("Jump") < 0 || Input.GetAxis ("Jump") > 0))
			Application.LoadLevel("");
		else if ((Input.GetButton ("FireR")) && (Input.GetAxis ("Jump") < 0 || Input.GetAxis ("Jump") > 0))
		{
			Texture2D image = (Texture2D)Resources.Load("popup1");
			GUI.DrawTexture(new Rect(0, 0, image.width, image.height), image);
			Debug.Log ("0");
		}
		else if ((Input.GetButton ("FireY")) && (Input.GetAxis ("Jump") < 0 || Input.GetAxis ("Jump") > 0))
			Application.LoadLevel("");
		else{}
	}
}
