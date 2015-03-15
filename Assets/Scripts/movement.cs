using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
	public float CurrY = 85.0f;
	public float Spacing = 170.0f;
	public Sprite player;

	private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer> ();	
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.y == 85.0f) {
			if (Input.GetAxis ("Jump") > 0) {
				CurrY += Spacing;
				Vector2 v = new Vector2(gameObject.transform.position.x, CurrY);
				gameObject.transform.position = v;
			}
		} else if (gameObject.transform.position.y == 255.0f) {
			if (Input.GetAxis ("Jump") > 0) {
				CurrY += Spacing;
				Vector2 v = new Vector2(gameObject.transform.position.x, CurrY);
				gameObject.transform.position = v;
			} else if (Input.GetAxis ("Jump") > 0) {
				CurrY -= Spacing;
				Vector2 v = new Vector2(gameObject.transform.position.x, CurrY);
				gameObject.transform.position = v;
			}
		} else {
			if (Input.GetAxis ("Jump") < 0) {
				CurrY -= Spacing;
				Vector2 v = new Vector2(gameObject.transform.position.x, CurrY);
				gameObject.transform.position = v;
			}
		}
	}
}

