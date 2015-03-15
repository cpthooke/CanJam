using UnityEngine;
using System.Collections;

public class logoTimer : MonoBehaviour {
	public Sprite sprite1;
	public Sprite sprite2;
	public float Timer = 1.0f;
	private SpriteRenderer spriteRenderer;
	float ans = 0;

	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer> ();	
	}
	
	// Update is called once per frame
	void Update () {
		Timer += Time.deltaTime;

		ans = Timer % 2;
		spriteRenderer.sprite = sprite1;
		Debug.Log (ans);
		while (ans < 1)
			spriteRenderer.sprite = sprite2;
		//else
		//	spriteRenderer.sprite = sprite1;
	}
}
