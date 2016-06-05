using UnityEngine;
using System.Collections;

public class PacmanMove : MonoBehaviour
{
	public int cheating;
	GameObject[] ghosts;
    bool waiting;

	public GhostMovePathInCode scriptOne;
	/* public GhostMovePathInCode scriptTwo;
	public GhostMovePathInCode scriptThree;
	public GhostMovePathInCode scriptFour; */

	public float speed = 0.4f;
	Vector2 dest = Vector2.zero;

	void Start ()
	{
		dest = transform.position;
	}

	// Update is called once per frame
	void Update ()
	{
		GameObject[] ghosts = GameObject.FindGameObjectsWithTag ("Ghost");
		Debug.Log ("rozmiar ghosts"  + ghosts.Length);

		if ( ghosts.Length > 0)
		scriptOne = ghosts [0].GetComponent<GhostMovePathInCode> ();

	}


	IEnumerator Wait ()
	{

		Debug.Log ("waiting"); 
		yield return new WaitForSeconds (cheating);

		Debug.Log ("doing shit");


		for (int i = 0; i < ghosts.Length; i++)
        {
			ghosts [i].SetActive (true);
		}

        waiting = false;
	}



	void FixedUpdate ()
	{
		// Move closer to Destination
		Vector2 p = Vector2.MoveTowards (transform.position, dest, speed);
		GetComponent<Rigidbody2D> ().MovePosition (p);


		if (Input.GetKey (KeyCode.UpArrow))
			dest = (Vector2)transform.position + Vector2.up;
		if (Input.GetKey (KeyCode.RightArrow))
			dest = (Vector2)transform.position + Vector2.right;
		if (Input.GetKey (KeyCode.DownArrow))
			dest = (Vector2)transform.position - Vector2.up;
		if (Input.GetKey (KeyCode.LeftArrow))
			dest = (Vector2)transform.position - Vector2.right;

		// Animation Parameters
		Vector2 dir = dest - (Vector2)transform.position;
		GetComponent<Animator> ().SetFloat ("DirX", dir.x);
		GetComponent<Animator> ().SetFloat ("DirY", dir.y);
	}

	void OnTriggerEnter2D (Collider2D co)
	{


		if (co.tag == "superDot")
        {
            if (waiting == false)
            {
                ghosts = GameObject.FindGameObjectsWithTag("Ghost");

                for (int i = 0; i < ghosts.Length; i++)
                {
                    ghosts[i].SetActive(false);

                    ghosts[i].GetComponent("GhostMovePathInCode");
                    StartCoroutine(Wait());
                    Debug.Log("po wait");

                }

                waiting = true;
            }

            Destroy(co.gameObject);
        }


	}
}
