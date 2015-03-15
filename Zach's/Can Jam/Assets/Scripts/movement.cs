using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
	public float CurrY = 0.0f;
	//public float Spacing = 4.0f;
	public Sprite player;
	float timer = 0.0f;
	private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer> ();	
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer > 0.15f)
		{
		if ((gameObject.transform.position.y == -2.0f) && (Input.GetButton ("FireR") == false) && (Input.GetButton ("FireB") == false) && (Input.GetButton ("FireY") == false) && (Input.GetButton ("FireG") == false) && (Input.GetButton ("FireO") == false)){
			if (Input.GetAxis ("GateOn") > 0) {
				CurrY = 1.0f;
				Vector3 v = new Vector3(gameObject.transform.position.x, CurrY,gameObject.transform.position.z);
				gameObject.transform.position = v;
				Debug.Log("1");
			}
		}
		else if ((gameObject.transform.position.y == 3.0f) && (!Input.GetButton ("FireR")) && (!Input.GetButton ("FireB")) && (!Input.GetButton ("FireY")) && (!Input.GetButton ("FireG")) && (!Input.GetButton ("FireO"))){
			if (Input.GetAxis ("GateOn") < 0) {
				CurrY = 1.0f;
				Vector3 v = new Vector3(gameObject.transform.position.x, CurrY,gameObject.transform.position.z);
				gameObject.transform.position = v;
				Debug.Log("4");
			}
		}
		else if((gameObject.transform.position.y == 1.0f) && (!Input.GetButton ("FireR")) && (!Input.GetButton ("FireB")) && (!Input.GetButton ("FireY")) && (!Input.GetButton ("FireG")) && (!Input.GetButton ("FireO"))){
			if (Input.GetAxis ("GateOn") > 0) {
				CurrY = 3.0f;
				Vector3 v = new Vector3(gameObject.transform.position.x, CurrY,gameObject.transform.position.z);
				gameObject.transform.position = v;
				Debug.Log("2");
			} else if (Input.GetAxis ("GateOn") < 0) {
				CurrY = -2.0f;
				Vector3 v = new Vector3(gameObject.transform.position.x, CurrY,gameObject.transform.position.z);
				gameObject.transform.position = v;
				Debug.Log("3");
			}
		}
			timer = 0.0f;
		}
	}
}

