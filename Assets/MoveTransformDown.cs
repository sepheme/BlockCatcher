using UnityEngine;
using System.Collections;

public class MoveTransformDown : MonoBehaviour {

	public float transformSpeed = 0.08f;

	void Start () {
	
	}
	

	void Update () {
		moveToBottom ();
	}

	void moveToBottom(){
		transform.Translate (0, -transformSpeed, 0);
	}
}
