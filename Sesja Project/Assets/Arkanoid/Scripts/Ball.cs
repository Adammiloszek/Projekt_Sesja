using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Ball : MonoBehaviour {

    float speed = 200;

    public static bool updateON = true;

    Vector2 vector;

    Rigidbody2D ball ;

    // Use this for initialization
    void Start() {

        ball = GetComponent<Rigidbody2D>();
        
        ball.velocity = Vector2.up * speed;

        //rozmiar w zależności od statystyki Ściąganie
        this.transform.localScale = this.transform.localScale + (new Vector3(Stats.Cheating * 0.05f, Stats.Cheating * 0.05f, 0));
    }

    // Update is called once per frame
    void Update()
    {

            //jeśli skończył się czas to zatrzymaj piłkę 
            if (!updateON)
            {
              ball.velocity = Vector2.up * 0;
              ball.velocity = Vector2.right * 0;
            }

            //jeśli piłka jest poniżej podstawki to ją zatrzymaj
             else  if (GetComponent<Rigidbody2D>().position.y < -105)
            {


               ball.velocity = Vector2.up * 0;
               ball.velocity = Vector2.right * 0;

                Timer.updateON = false;

                Main.ResetBall();
            
            }



            //jeśli wszystkie bloki zbite to zatrzymaj piłkę
            else if (Main.Bloki == 0)
            {
                GetComponent<Rigidbody2D>().velocity = Vector2.up * 0;
                GetComponent<Rigidbody2D>().velocity = Vector2.right * 0;

                Main.Zwyciestwo();
            }
    }

   

    //w jaka czesc podstawki uderzono
    float hitFactor(Vector2 ballPos, Vector2 racketPos,
                float racketWidth)
    {
        return (ballPos.x - racketPos.x) / racketWidth;
    }

    //odbicie od podstawki
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "racket")
        {
            
            float x = hitFactor(transform.position,
                              col.transform.position,
                              col.collider.bounds.size.x);

           
            Vector2 dir = new Vector2(x, 1).normalized;

            
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
    }

}
