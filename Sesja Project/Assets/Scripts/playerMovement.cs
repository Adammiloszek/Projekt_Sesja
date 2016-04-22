using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {

    public int speed = 5;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.GetComponent<Rigidbody>().velocity = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0) * speed;

    }
}
