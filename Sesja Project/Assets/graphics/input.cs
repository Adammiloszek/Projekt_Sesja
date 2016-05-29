using UnityEngine;
using System.Collections;

public class input : MonoBehaviour {

    public GameObject postac;
    public float speed = 0.1f;

	// Use this for initialization
	void Start () {

	}
    // Update is called once per frame
    
    void FixedUpdate () {
        if (Input.GetKey("up"))
            postac.GetComponent<Transform>().transform.position += new Vector3(0, speed, 0);

        if (Input.GetKey("down"))
            postac.GetComponent<Transform>().transform.position -= new Vector3(0, speed, 0);

        if (Input.GetKey("left"))
            postac.GetComponent<Transform>().transform.position -= new Vector3(speed, 0, 0);

        if (Input.GetKey("right"))
            postac.GetComponent<Transform>().transform.position += new Vector3(speed, 0, 0);
	}
}
