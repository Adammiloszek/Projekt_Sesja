using UnityEngine;
using System.Collections;

public class Racket : MonoBehaviour {

    public float speed = 150;

    GameObject ballObj;

    // Use this for initialization
    void Start () {
	ballObj = GameObject.Find("ball");
    }
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxisRaw("Horizontal");
        

        if(ballObj.GetComponent<Rigidbody2D>().velocity.x == 0)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.right * h * 0;

        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;
        }
    }

   
}
