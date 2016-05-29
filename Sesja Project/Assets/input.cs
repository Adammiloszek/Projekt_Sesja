using UnityEngine;
using System.Collections;

public class input : MonoBehaviour {

    public GameObject postac;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("up"))
        {
            postac.GetComponent<Transform>().transform.position += new Vector3(0, 0.1f, 0);
            
        }



        if (Input.GetKey("down"))
        {
            postac.GetComponent<Transform>().transform.position -= new Vector3(0, 0.1f, 0);
            
        }

        if (Input.GetKey("left"))
        {
            postac.GetComponent<Transform>().transform.position -= new Vector3(0.1f, 0, 0);
            
        }

        if (Input.GetKey("right"))
        {
            postac.GetComponent<Transform>().transform.position += new Vector3(0.1f, 0, 0);
            
        }
	}
}
