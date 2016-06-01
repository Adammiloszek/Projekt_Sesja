using UnityEngine;
using System.Collections;

public class GhostMovePathInCode : MonoBehaviour {

	private Transform[] waypoints = new Transform[9];
	
	public Rigidbody2D rb;
	
	void Start ()
	{
		rb = GetComponent<Rigidbody2D> ();
		waypoints[0] = GameObject.Find("Waypoint50").transform;
		waypoints[1] = GameObject.Find("Waypoint52").transform;
		waypoints[2] = GameObject.Find("Waypoint91").transform;
		waypoints[3] = GameObject.Find("Waypoint92").transform;
		waypoints[4] = GameObject.Find("Waypoint72").transform;
		waypoints[5] = GameObject.Find("Waypoint78").transform;
		waypoints[6] = GameObject.Find("Waypoint27").transform;
		waypoints[7] = GameObject.Find("Waypoint21").transform;
		waypoints[8] = GameObject.Find("Waypoint42").transform;
		
		
		
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
		GetComponent<Animator>().SetFloat("DirX", dir.x);
		GetComponent<Animator>().SetFloat("DirY", dir.y);
	}
	void OnTriggerEnter2D(Collider2D co)
	{
		if (co.name == "pacman")
			Destroy(co.gameObject);
	}
}

