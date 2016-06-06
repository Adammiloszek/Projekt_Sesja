using UnityEngine;
using System.Collections;

public class superDot : MonoBehaviour {
	GameObject[] ghosts;

	public GhostMovePathInCode scriptOne;
	/* public GhostMovePathInCode scriptTwo;
	public GhostMovePathInCode scriptThree;
	public GhostMovePathInCode scriptFour; */	

	// Use this for initialization
	void Start () {

	}



	 
	
	//// Update is called once per frame
	//void Update () {
	//	GameObject[] ghosts = GameObject.FindGameObjectsWithTag ("Ghost");
	//	scriptOne = ghosts [0].GetComponent<GhostMovePathInCode> ();

	//}

	//IEnumerator Wait()
	//{
		
	//	Debug.Log ("waiting"); // runs
	//	yield return new WaitForSeconds (5.1f);

	//	Debug.Log ("doing shit");	// won't run.
	//	/* scriptOne.speed = 0;
	//	ghosts [0].SetActive (false); // nie wywoluje sie.  */
	//}

	//void OnTriggerEnter2D(Collider2D co) {
	//	ghosts = GameObject.FindGameObjectsWithTag ("Ghost");

	//	if (co.name == "pacman") {

 //           // Destroy (gameObject);

 //           for (int i = 0; i < ghosts.Length; i++)
 //           {
 //               // ghosts [i].SetActive (false);

 //               ghosts[i].GetComponent("GhostMovePathInCode");
 //               StartCoroutine(Wait());
 //               Debug.Log("po wait"); // instantly writes that

 //           }

 //       }

	//}


}
