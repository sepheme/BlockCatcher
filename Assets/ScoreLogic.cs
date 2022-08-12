using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreLogic : MonoBehaviour {

	public int scoreCount = 0;

	Text scoreText;

	void Start () {
		scoreText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		printScore ();
	}

	public void updateScore(){
		scoreCount = scoreCount + 1;
		printScore ();
	}

	public void printScore (){
		scoreText.text = "Score: " + scoreCount;
	}

}
