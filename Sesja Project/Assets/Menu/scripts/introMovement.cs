using UnityEngine;
using System.Collections;

public class introMovement : MonoBehaviour {

	public GameObject camera;
	public float fadeSpeed = 1.5f;

	Vector3[] nodes = new Vector3[4];
	bool[] reached = new bool[4];


	// Use this for initialization
	void Start () {
		nodes[0] = new Vector3(-2.55f,-6.76f,0.0f);
	  nodes[1] = new Vector3(-0.06f,-6.61f,0.0f);
	  nodes[2] = new Vector3(0.14f,-4.23f,0.0f);
	  nodes[3] = new Vector3(8.37f,-4.17f,0.0f);

		float fadeTime = GameObject.Find("wkampus_concept (1)").GetComponent<Fading>().BeginFade(1);
	}

	// Update is called once per frame
	void Update () {
		//move the camera airly
		float cameraStep = 4f * Time.deltaTime;
		camera.transform.position = Vector3.MoveTowards(camera.transform.position, new Vector3(4.0f,8.0f,0.0f), cameraStep);


		//make bohater follow the path!
		float step = 2.58f * Time.deltaTime;
		if(!reached[0])
		{
    	transform.position = Vector3.MoveTowards(transform.position, nodes[0], step);
			if(transform.position == nodes[0])
				reached[0] = true;
		}
		else if(!reached[1]){
			transform.position = Vector3.MoveTowards(transform.position, nodes[1], step);
			if(transform.position == nodes[1])
				reached[1] = true;
		}
		else if(!reached[2]){
			transform.position = Vector3.MoveTowards(transform.position, nodes[2], step);
			if(transform.position == nodes[2])
				reached[2] = true;
		}
		else if(!reached[3]){
			transform.position = Vector3.MoveTowards(transform.position, nodes[3], step);
			if(transform.position == nodes[3])
				reached[3] = true;
		}
		else {
			Application.LoadLevel("Menu_Scene");
		}
	}
}
