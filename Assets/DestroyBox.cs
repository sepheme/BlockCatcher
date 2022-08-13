using UnityEngine;
using System.Collections;

public class DestroyBox : MonoBehaviour {

	

	void Start () {
	
	}
	

	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D transformCollision){
		if (transformCollision.gameObject.tag == "Box") {
			Destroy (transformCollision.gameObject);
		}
	}
}
