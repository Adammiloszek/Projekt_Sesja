using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    float speed = 100;

 

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
      
    }

    // Update is called once per frame
    void Update()
    {

        if (GetComponent<Rigidbody2D>().position.y < -105)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * 0;
            GetComponent<Rigidbody2D>().velocity = Vector2.right * 0;
           
        }
    }

    //w jaka czesc podstawki uderzono
    float hitFactor(Vector2 ballPos, Vector2 racketPos,
                float racketWidth)
    {
        return (ballPos.x - racketPos.x) / racketWidth;
    }

    //odbicie od podstawki
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "racket")
        {
            
            float x = hitFactor(transform.position,
                              col.transform.position,
                              col.collider.bounds.size.x);

           
            Vector2 dir = new Vector2(x, 1).normalized;

            
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
    }

}
