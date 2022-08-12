using UnityEngine;
using System.Collections;

public class PlayerLogic : MonoBehaviour {

	public float playerSpeed = 0.8f;

	float maxPlayerXDistance = 12.0f;

	void Start () {
	
	}
	
	void Update () {
		playerMovement ();
	}

	void playerMovement(){
		if (Input.GetKey(KeyCode.A) && transform.position.x >= -maxPlayerXDistance){
			transform.Translate(-playerSpeed,0,0);
		}

		if (Input.GetKey(KeyCode.D) && transform.position.x <= maxPlayerXDistance){
			transform.Translate(playerSpeed,0,0);
		}
	}
}
