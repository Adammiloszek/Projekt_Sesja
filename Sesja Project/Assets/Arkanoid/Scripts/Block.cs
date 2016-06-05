using UnityEngine;
using System.Collections;


public class Block : MonoBehaviour {



    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        // usuń blok
        
       Destroy(gameObject);
        
       
    }
}
