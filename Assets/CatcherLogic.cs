using UnityEngine;
using System.Collections;

public class CatcherLogic : MonoBehaviour {
	
	public float blockSpeed = 0.2f;

	float maxBlockXDistance = 12.0f;

	void Start () {

	}

	void Update () {
		blockMovement ();
	}

	void blockMovement(){
		if (Input.GetKey(KeyCode.A) && transform.position.x >= -maxBlockXDistance){
			transform.Translate(-blockSpeed,0,0);
		}

		if (Input.GetKey(KeyCode.D) && transform.position.x <= maxBlockXDistance){
			transform.Translate(blockSpeed,0,0);
		}
	}
}
