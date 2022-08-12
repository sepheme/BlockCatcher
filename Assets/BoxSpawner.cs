using UnityEngine;
using System.Collections;

public class BoxSpawner : MonoBehaviour {

	public GameObject boxToSpawn;

	public float spawnTime = 0.8f;

	public float startingY = 4.20f;

	public float maxDistance = 12.0f;

	public bool canSpawn = true;

	float randomX = 0.0f;

	void Start () {
		StartCoroutine (spawnBoxTimer());
	}
	

	void Update () {
	
	}

	void spawnBox(){
		randomX = Random.Range (-maxDistance, maxDistance);
		Instantiate (
						boxToSpawn, 
						new Vector3 (randomX, startingY, 0), 
						Quaternion.identity
					);
	}

	IEnumerator spawnBoxTimer(){
		while (canSpawn == true) {
			spawnBox ();
			yield return new WaitForSeconds (spawnTime);
		}
	}
}
