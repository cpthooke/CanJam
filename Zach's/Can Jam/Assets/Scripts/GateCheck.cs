using UnityEngine;
using System.Collections;

public class GateCheck : MonoBehaviour 
{
	int timer = 0;

	void OnTriggerEnter(Collider other)
	{
		Vector3 playerPosition;
		Sprite sprite = other.GetComponent<SpriteRenderer>().sprite;

		if (other.tag == "Gate" && other.GetComponent<SpriteRenderer> ()) 
		{
			if(sprite.name == "B_Off" && other.gameObject.name == "BlueGate(Clone)")
			{
				playerPosition = this.transform.position;
				playerPosition.x--;
				this.transform.position = playerPosition;
				this.GetComponent<BoxCollider>().enabled = false;
				timer = 60;
			}

			if(sprite.name == "R_Off" && other.gameObject.name == "RedGate(Clone)")
			{
				playerPosition = this.transform.position;
				playerPosition.x--;
				this.transform.position = playerPosition;
				this.GetComponent<BoxCollider>().enabled = false;
				timer = 60;
			}

			if(sprite.name == "Y_Off" && other.gameObject.name == "YellowGate(Clone)")
			{
				playerPosition = this.transform.position;
				playerPosition.x--;
				this.transform.position = playerPosition;
				this.GetComponent<BoxCollider>().enabled = false;
				timer = 60;
			}

			if(sprite.name == "G_Off" && other.gameObject.name == "GreenGate(Clone)")
			{
				playerPosition = this.transform.position;
				playerPosition.x--;
				this.transform.position = playerPosition;
				this.GetComponent<BoxCollider>().enabled = false;
				timer = 60;
			}

			if(sprite.name == "O_Off" && other.gameObject.name == "OrangeGate(Clone)")
			{
				playerPosition = this.transform.position;
				playerPosition.x--;
				this.transform.position = playerPosition;
				this.GetComponent<BoxCollider>().enabled = false;
				timer = 60;
			}
		}
		
		if (other.gameObject.name == "MOVE") 
		{
			playerPosition = this.transform.position;
			playerPosition.x--;
			this.transform.position = playerPosition;
			this.GetComponent<BoxCollider>().enabled = false;
			timer = 60;
		} 
	}

	void Update()
	{
		if (timer > 0)
			timer--;
		else
			this.GetComponent<BoxCollider> ().enabled = true;
	}
}
