﻿using UnityEngine;
using System.Collections;

public class bChange : MonoBehaviour {
	public Sprite sprite1;
	public Sprite sprite2;
	
	private SpriteRenderer spriteRenderer;
	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.GetButton ("FireB")) && (Input.GetAxis ("Jump") < 0 || Input.GetAxis ("Jump") > 0)) {
			spriteRenderer.sprite = sprite2;
			//Debug.Log (Input.GetButton ("FireB").ToString ());
			//Debug.Break();
		}
			else
			spriteRenderer.sprite = sprite1;
	}
}
