using UnityEngine;
using System.Collections;

public class createGhosts : MonoBehaviour {

	public GameObject pinky;
	public GameObject clyde;
	public GameObject inky;
	public GameObject blinky;
	// public int knowledge; // w zaleznosci od wiedzy od 0 do 4, 0 wiedzy ->  4 duszki, 4 wiedzy -> 0 duszków do testów


	// ze wiedza max 10; to podzielic przez 2 i podloge - 2
	// wiedzy 2 -> jak 0
	// wiedzy 3 -> jak 0 bo podloga
	// wiedzy 4 -> jak 1
	// wiedzy 6 -> jak 2
	// wiedza 9 ->   (9-2) /2 = 7/2 =  jak 3

	int knowledge = (Stats.Knowledge-2)/2;


	// Use this for initialization
	void Start () {
		
		if (knowledge < 0 ) {
			knowledge = 0;
		}

		GameObject[] ghosts = new GameObject[4];
		ghosts [0] = pinky;
		ghosts [1] = clyde;
		ghosts [2] = inky;
		ghosts [3] = blinky;

		Vector2[] startingVectors = new Vector2[4];
		startingVectors [0] = new Vector2 (15f, 17f); // lewy górny róg
		startingVectors [1] = new Vector2 (15f, 17f); // prawy górny róg
        startingVectors[2] = new Vector2(15f, 17f); // lewy dolny róg
        startingVectors[3] = new Vector2(15f, 17f); // prawy dolny róg
	

		Debug.Log (knowledge + "K");
		Debug.Log (ghosts.Length + "L");

		for (int i = 1; i <= ghosts.Length - knowledge; i++) {

			Instantiate(ghosts[i-1], startingVectors[i-1], Quaternion.identity);

	
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
