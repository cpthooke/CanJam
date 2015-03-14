using UnityEngine;
using System.Collections;

public class spriteChange : MonoBehaviour {
	
	public Sprite sprite1;
	public Sprite sprite2;
	public Sprite spriteR;
	public Sprite spriteY;
	public Sprite spriteB;
	public Sprite spriteO;

	private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer> ();

	}
	
	// Update is called once per frame
	void Update () {
		spriteRenderer.sprite = sprite1;
		if(Input.GetKey (KeyCode.Q)) {
			spriteRenderer.sprite = sprite2;
		}
		else if(Input.GetKey (KeyCode.W)) {
			spriteRenderer.sprite = spriteR;
		}
		else if(Input.GetKey (KeyCode.E)) {
			spriteRenderer.sprite = spriteY;
		}
		else if(Input.GetKey (KeyCode.R)) {
			spriteRenderer.sprite = spriteB;
		}
		else if(Input.GetKey (KeyCode.T)) {
			spriteRenderer.sprite = spriteO;
		}
		else
			spriteRenderer.sprite = sprite1;
		if (Input.GetMouseButton (0))
			spriteRenderer.sprite = sprite2;
		else
			spriteRenderer.sprite = sprite1;
	}
		
	
}

	//void OnMouseDown ()
	//{
	//}

