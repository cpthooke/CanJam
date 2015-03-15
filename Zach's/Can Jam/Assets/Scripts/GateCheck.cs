using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GateCheck : MonoBehaviour 
{
	int timer = 0;
	public int playerScore = 0;
	public GameObject ending;
	public Text score;
	//public GUIText score;
	//public Canvas score;

	void OnTriggerEnter(Collider other)
	{
			if (other.gameObject.name == "PlayerDestroyer") 
			{
				//End game
				//Application.LoadLevel("GameOver");

				ending.GetComponent<MeshRenderer>().enabled = true;

				//print("Gates passed: " + playerScore);

			score.text = "Gates passed: " + playerScore;
			} 
			else 
			{
				Vector3 playerPosition;
				Sprite sprite = other.GetComponent<SpriteRenderer> ().sprite;

				if (other.tag == "Gate" && other.GetComponent<SpriteRenderer> ()) {
					//Hurt Player
					if (sprite.name == "B_Off" && other.gameObject.name == "BlueGate(Clone)") {
						playerPosition = this.transform.position;
						playerPosition.x--;
						this.transform.position = playerPosition;
						this.GetComponent<BoxCollider> ().enabled = false;
						timer = 60;
					}

					if (sprite.name == "R_Off" && other.gameObject.name == "RedGate(Clone)") {
						playerPosition = this.transform.position;
						playerPosition.x--;
						this.transform.position = playerPosition;
						this.GetComponent<BoxCollider> ().enabled = false;
						timer = 60;
					}

					if (sprite.name == "Y_Off" && other.gameObject.name == "YellowGate(Clone)") {
						playerPosition = this.transform.position;
						playerPosition.x--;
						this.transform.position = playerPosition;
						this.GetComponent<BoxCollider> ().enabled = false;
						timer = 60;
					}

					if (sprite.name == "G_Off" && other.gameObject.name == "GreenGate(Clone)") {
						playerPosition = this.transform.position;
						playerPosition.x--;
						this.transform.position = playerPosition;
						this.GetComponent<BoxCollider> ().enabled = false;
						timer = 60;
					}

					if (sprite.name == "O_Off" && other.gameObject.name == "OrangeGate(Clone)") {
						playerPosition = this.transform.position;
						playerPosition.x--;
						this.transform.position = playerPosition;
						this.GetComponent<BoxCollider> ().enabled = false;
						timer = 60;
					}

					//Player Scores
					if (sprite.name == "B_On" && other.gameObject.name == "BlueGate(Clone)") {
						playerScore++;
					}
					
					if (sprite.name == "R_On" && other.gameObject.name == "RedGate(Clone)") {
						playerScore++;
					}
					
					if (sprite.name == "Y_On" && other.gameObject.name == "YellowGate(Clone)") {
						playerScore++;
					}
					
					if (sprite.name == "G_On" && other.gameObject.name == "GreenGate(Clone)") {
						playerScore++;
					}
					
					if (sprite.name == "O_On" && other.gameObject.name == "OrangeGate(Clone)") {
						playerScore++;
					}
				}
				
				if (other.gameObject.name == "MOVE") {
					playerPosition = this.transform.position;
					playerPosition.x--;
					this.transform.position = playerPosition;
					this.GetComponent<BoxCollider> ().enabled = false;
					timer = 60;
				}
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
