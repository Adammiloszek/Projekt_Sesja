using UnityEngine;
using System.Collections;

public class StrongBlock : MonoBehaviour {

    int life;

	// Use this for initialization
	void Start () {
        life = 2;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        // jeśli uderzono 2 razy usun blok
        life--;

        if (life <= 0)
        {
            Destroy(gameObject);
        }
       


    }
}
