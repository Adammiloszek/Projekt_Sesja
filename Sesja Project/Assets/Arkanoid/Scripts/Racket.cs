using UnityEngine;
using System.Collections;

public class Racket : MonoBehaviour {

    public float speed = 150;

    GameObject ballObj;

    Rigidbody2D racket;

    float h;

    public static bool updateON = true;

    // Use this for initialization
    void Start () {

        ballObj = GameObject.Find("ball");

        this.transform.localScale = this.transform.localScale + (new Vector3(Stats.Knowledge * 0.03f, 0, 0));

       

        racket = GetComponent<Rigidbody2D>();

        racket.velocity = Vector2.right * h * speed;
    }
	
	// Update is called once per frame
	void Update() {


        h = Input.GetAxisRaw("Horizontal");

        racket.velocity = Vector2.right * h * speed;

        
    }


   
}
