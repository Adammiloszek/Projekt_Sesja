using UnityEngine;
using System.Collections;

public class createGhosts : MonoBehaviour {

	public GameObject pinky;
	public GameObject clyde;
	public GameObject inky;
	public GameObject blinky;
	public int knowledge; // w zaleznosci od wiedzy od 0 do 4, 0 wiedzy ->  4 duszki, 4 wiedzy -> 0 duszków

	// Use this for initialization
	void Start () {

		GameObject[] ghosts = new GameObject[4];
		ghosts [0] = pinky;
		ghosts [1] = clyde;
		ghosts [2] = inky;
		ghosts [3] = blinky;

		Vector2[] startingVectors = new Vector2[4];
		startingVectors [0] = new Vector2 ((-13f + 15f), (10f + 20f));
		startingVectors [1] = new Vector2 (12.00f + 15.0f, -18.00f + 20.0f);
		startingVectors [2] = new Vector2 (26.82f, 29.94f);
		startingVectors [3] = new Vector2 (15f, 17f);


		/*
		GameObject pinky = GameObject.Find ("pinky");
		GameObject clyde = GameObject.Find ("clyde");
		GameObject inky = GameObject.Find ("inky");
		GameObject blinky = GameObject.Find ("blinky"); */
		
	/*	Instantiate (pinky, new Vector2 ((-13f+15f), (10f+20f)), Quaternion.identity);
		Instantiate (clyde, new Vector2(12.00f+15.0f, -18.00f+20.0f), Quaternion.identity);
		Instantiate (inky, new Vector2 (26.82f, 29.94f), Quaternion.identity);
		Instantiate (blinky, new Vector2 (15f, 17f), Quaternion.identity);	*/

		for (int i = 1; i <= ghosts.Length - knowledge; i++) {

			Instantiate(ghosts[i-1], startingVectors[i-1], Quaternion.identity);

	
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
