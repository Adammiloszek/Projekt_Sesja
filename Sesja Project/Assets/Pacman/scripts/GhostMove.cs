using UnityEngine;
using System.Collections;

public class GhostMove : MonoBehaviour
{
    public Transform[] waypoints;
    int cur = 0;    

    public float speed = 0.3f;

    void FixedUpdate()
    {
        if  ((transform.position.x - waypoints[cur].position.x > 0.01 || transform.position.x - waypoints[cur].position.x <-0.01) ||
            (transform.position.y - waypoints[cur].position.y > 0.01 || transform.position.y - waypoints[cur].position.y < -0.01))
        
        {
            Vector2 p = Vector2.MoveTowards(transform.position,
                                            waypoints[cur].position,
                                            speed);
            GetComponent<Rigidbody2D>().MovePosition(p);
        }
        else cur = (cur + 1) % waypoints.Length;
        // Animation
        Vector2 dir = waypoints[cur].position - transform.position;
        GetComponent<Animator>().SetFloat("DirX", dir.x);
        GetComponent<Animator>().SetFloat("DirY", dir.y);
    }
    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "pacman")
            Destroy(co.gameObject);
    }
}

