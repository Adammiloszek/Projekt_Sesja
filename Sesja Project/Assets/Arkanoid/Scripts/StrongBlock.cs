﻿using UnityEngine;
using System.Collections;

public class StrongBlock : MonoBehaviour {

    int life;

	// Use this for initialization
	void Start () {
        life = 2;
        Main.Bloki++;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        // jeśli uderzono 2 razy usun blok
        life--;

        if (life == 1)
        {
            GameObject go = GameObject.Find("blockchange");
            Sprite sprt = go.GetComponent<SpriteRenderer>().sprite;
            gameObject.GetComponent<SpriteRenderer>().sprite = sprt;
        }

        if (life <= 0)
        {
            Main.Punkty += 20;
            Main.Bloki--;

            Destroy(gameObject);
        }
       


    }
}
