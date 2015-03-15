using UnityEngine;
using System.Collections;

public class GateCheckB : MonoBehaviour 
{
	void OnTriggerEnter(Collider other)
	{
		Vector3 playerPosition;
		Sprite sprite = other.GetComponent<SpriteRenderer>().sprite;

		if (other.tag == "Gate" && other.GetComponent<SpriteRenderer> ()) 
		{
			switch(sprite.name)
			{
			case "B_Off":
			case "R_Off":
				playerPosition = this.transform.position;
				playerPosition.x--;
				this.transform.position = playerPosition;
				this.GetComponent<BoxCollider>().enabled = false;
				break;
			}
			if (sprite.name == "B_Off") 
			{
				playerPosition = this.transform.position;
				playerPosition.x--;
				this.transform.position = playerPosition;
				this.GetComponent<BoxCollider>().enabled = false;
			}
		}
		
		if (other.tag == "MOVE") 
		{
			playerPosition = this.transform.position;
			playerPosition.x--;
			this.transform.position = playerPosition;
		} 
	}
}
