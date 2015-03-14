using UnityEngine;
using System.Collections;

public class spriteChanger : MonoBehaviour {

	public Sprite[] spriteDeactiveArray = new Sprite[5];
	private Sprite[] spriteArray = new Sprite[5];
	public Sprite[] spriteActiveArray = new Sprite[5];
	SpriteRenderer spriteRenderer;
	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		bool[] buttonPressed = new bool[5];
		if(Input.GetKey (KeyCode.Q)) {
			buttonPressed[0] = true;
		}
		if(Input.GetKey (KeyCode.W)) {
			buttonPressed[1] = true;		}
		if(Input.GetKey (KeyCode.E)) {
			buttonPressed[2] = true;		}
		if(Input.GetKey (KeyCode.R)) {
			buttonPressed[3] = true;		}
		if(Input.GetKey (KeyCode.T)) {
			buttonPressed[4] = true;		}

		for(int i = 0; i < spriteArray.Length; i++){
			if(buttonPressed[i] == true){
				spriteArray[i] = spriteActiveArray[i];
			}
			else{
				spriteArray[i] = spriteDeactiveArray[i];
			}
			buttonPressed[i] = false;
			spriteRenderer.sprite = spriteArray[i];
		}
	}
}
