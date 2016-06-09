using UnityEngine;
using System.Collections;

public class pacdot : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D co)
    {


		if (co.name == "pacman")
        {
			Destroy(gameObject);
		}

        if (co.name == "maze")
        {
            Destroy(co.gameObject);
        }
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
		Debug.Log ("destroyed");
        if (collisionInfo.gameObject.name == "maze")
        {
            Destroy(collisionInfo.gameObject);

        }
    }

    void FixedUpdate()
    {
        GetComponent<Collider2D>();
    }
}