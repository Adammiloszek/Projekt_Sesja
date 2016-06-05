using UnityEngine;
using System.Collections;

public class GhostMovePathInCode : MonoBehaviour {

	private Transform[] waypoints;
	
	public Rigidbody2D rb;

	public Animator animator;
	
	void Start ()
	{
		rb = GetComponent<Rigidbody2D> ();

		if (this.gameObject.name == "inky(Clone)") {
			waypoints = new Transform[9];
			Debug.Log("blinky ");
			waypoints [0] = GameObject.Find ("Waypoint50").transform;
			waypoints [1] = GameObject.Find ("Waypoint52").transform;
			waypoints [2] = GameObject.Find ("Waypoint91").transform;
			waypoints [3] = GameObject.Find ("Waypoint92").transform;
			waypoints [4] = GameObject.Find ("Waypoint72").transform;
			waypoints [5] = GameObject.Find ("Waypoint78").transform;
			waypoints [6] = GameObject.Find ("Waypoint27").transform;
			waypoints [7] = GameObject.Find ("Waypoint21").transform;
			waypoints [8] = GameObject.Find ("Waypoint42").transform;
		}


		if (this.gameObject.name == "blinky(Clone)") {
			waypoints = new Transform[7];
			Debug.Log("blinky ");
			waypoints [0] = GameObject.Find ("Waypoint44").transform;
			waypoints [1] = GameObject.Find ("Waypoint23").transform;
			waypoints [2] = GameObject.Find ("Waypoint26").transform;
			waypoints [3] = GameObject.Find ("Waypoint46").transform;
			waypoints [4] = GameObject.Find ("Waypoint45").transform;
			waypoints [5] = GameObject.Find ("Waypoint63").transform;
			waypoints [6] = GameObject.Find ("Waypoint62").transform;

		}


		if (this.gameObject.name == "clyde(Clone)") {
			waypoints = new Transform[5];
			Debug.Log("clyde ");
			waypoints [0] = GameObject.Find ("Waypoint09").transform;
			waypoints [1] = GameObject.Find ("Waypoint99").transform;
			waypoints [2] = GameObject.Find ("Waypoint98").transform;
			waypoints [3] = GameObject.Find ("Waypoint77").transform;	
			waypoints [4] = GameObject.Find ("Waypoint78").transform;

			
		}

		
		if (this.gameObject.name == "pinky(Clone)") {
			waypoints = new Transform[12];
			Debug.Log("pinky ");
			waypoints [0] = GameObject.Find ("Waypoint40").transform;
			waypoints [1] = GameObject.Find ("Waypoint41").transform;
			waypoints [2] = GameObject.Find ("Waypoint51").transform;
			waypoints [3] = GameObject.Find ("Waypoint52").transform;	
			waypoints [4] = GameObject.Find ("Waypoint91").transform;
			waypoints [5] = GameObject.Find ("Waypoint92").transform;
			waypoints [6] = GameObject.Find ("Waypoint72").transform;
			waypoints [7] = GameObject.Find ("Waypoint73").transform;	
			waypoints [8] = GameObject.Find ("Waypoint23").transform;
			waypoints [9] = GameObject.Find ("Waypoint22").transform;
			waypoints [10] = GameObject.Find ("Waypoint02").transform;
			waypoints [11] = GameObject.Find ("Waypoint00").transform;

			
			
		}
		
	}
	
	
	int wayPointsSize = 2;    
	int index = 0;
	
	
	public float speed = 0.3f;
	
	void FixedUpdate()
	{
		
		
		
		if  ((transform.position.x - waypoints[index].position.x > 0.01 || transform.position.x - waypoints[index].position.x <-0.01) ||
		     (transform.position.y - waypoints[index].position.y > 0.01 || transform.position.y - waypoints[index].position.y < -0.01))
			
		{
			Vector2 p = Vector2.MoveTowards(transform.position,
			                                waypoints[index].position,
			                                speed);
			rb.MovePosition(p);
		}
		else index = (index + 1) % waypoints.Length;
		// Animation
		Vector2 dir = waypoints[index].position - transform.position;
		animator.SetFloat("DirX", dir.x);
		animator.SetFloat("DirY", dir.y);	 // po zrobieniu animacji
	}
	void OnTriggerEnter2D(Collider2D co)
	{
		if (co.tag == "PacMan")
			Destroy(co.gameObject);
	}
}

