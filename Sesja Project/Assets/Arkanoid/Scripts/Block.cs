using UnityEngine;
using System.Collections;


public class Block : MonoBehaviour {

    
    void Start()
    {
        Main.Bloki++;
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        Main.Punkty += 10;
        Main.Bloki--;

        // usuń blok
        
       Destroy(gameObject);
        
       
    }
}
