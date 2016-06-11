using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Ball : MonoBehaviour {

    float speed = 200;

    private static bool updateON = true;

    private static bool chooseBallPosition = true;

    private GameObject textKlawisz;
    private GameObject textInfo;

    Vector2 vector;

    Rigidbody2D ball;

    GameObject racket;

    public static bool UpdateON
    {
        get { return updateON; }
        set { updateON = value; }
    }

    public static bool ChooseBallPosition
    {
        get { return chooseBallPosition; }
        set { chooseBallPosition = value; }
    }

    // Use this for initialization
    void Start() {

        ball = GetComponent<Rigidbody2D>();
        
        ball.velocity = Vector2.up * speed;

        racket = GameObject.Find("racket");

        //rozmiar w zależności od statystyki Ściąganie
        this.transform.localScale = this.transform.localScale + (new Vector3(Stats.Cheating * 0.02f, Stats.Cheating * 0.02f, 0));
    }

    // Update is called once per frame
    void Update()
    {

        if (chooseBallPosition)
        {
            textKlawisz = GameObject.Find("klawiszInfo");
            textKlawisz.GetComponent<Text>().text = "wciśnij SPACJĘ";
            textInfo = GameObject.Find("Text (2)");
            textInfo.GetComponent<Text>().text = "wybierz pozycję kulki";
            ball.transform.position = new Vector2(racket.GetComponent<Rigidbody2D>().transform.position.x, racket.GetComponent<Rigidbody2D>().transform.position.y + 25);
            if (Input.GetKeyDown("space"))
            {
                chooseBallPosition = false;
                Timer.UpdateON = true;
                Ball.UpdateON = true;
                textKlawisz.GetComponent<Text>().text = "";
                textInfo.GetComponent<Text>().text = "";
            }
        }
        else
        {
            
            if (ball.position.y < -110 && Main.Zycia == 0)
            {
                ball.velocity = new Vector2(0, 0);

                Timer.UpdateON = false;

                Main.KoniecCzasu(false, false);

            }
            //jeśli wszystkie bloki zbite to zatrzymaj piłkę
            else if (Main.Bloki == 0)
            {
                ball.velocity = Vector2.up * 0;
                ball.velocity = Vector2.right * 0;

                Main.KoniecCzasu(true, true);
            }
            //jeśli skończył się czas to zatrzymaj piłkę 
            else if (!updateON)
            {
                ball.velocity = Vector2.up * 0;
                ball.velocity = Vector2.right * 0;
            }
            //jeśli piłka jest poniżej podstawki to ją zatrzymaj
            else if (ball.position.y < -110)
            {


                ball.velocity = new Vector2(0, 0);

                Timer.UpdateON = false;

                Main.ResetBall();

            }

           //zresetuj piłkę jeśli wyleciała poza scene
            else if (ball.position.x < -120 || ball.position.x > 114)
            {
                ball.transform.position = new Vector2(-0.2f, -98.7f);
                ball.velocity = new Vector2(0, speed);

            }



            
        }
        
    }
    
    //w jaka czesc podstawki uderzono
    float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketWidth)
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
