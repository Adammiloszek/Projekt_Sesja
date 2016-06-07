using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public static class Main  {

    private static int punkty = 0;

    private static int zycia = 3;

    private static int bloki = 0;

    private static GameObject textInfo;

    private static GameObject racket;

    private static GameObject ball;



    public static int Punkty
    {
        get { return punkty; }
        set { punkty = value; }
    }

    public static int Zycia
    {
        get { return zycia; }
        set { zycia = value; }
    }

    public static int Bloki
    {
        get { return bloki; }
        set { bloki = value; }
    }

    static public void ResetBall()
    {

        textInfo = GameObject.Find("Text (2)");

        racket = GameObject.Find("racket");

        ball = GameObject.Find("ball");


        textInfo.GetComponent<Text>().text = "Wciśnij spacje";

        if (Input.GetKeyDown("space"))
        {
            zycia--;

            if(zycia > 0)
            {
                  //ustaw podstawke
                racket.GetComponent<Rigidbody2D>().transform.position = new Vector2(-0.2f, -98.7f);

                //ustaw pilke i ruch piłki
                ball.GetComponent<Rigidbody2D>().velocity = Vector2.up * 200;
                ball.GetComponent<Rigidbody2D>().transform.position = new Vector2(-1.8f, -74);

                textInfo.GetComponent<Text>().text = "";

                Timer.updateON = true;
            }
            else
            {

                Porazka();
               
            }
          

          

        }
        

    }

  public static void Zwyciestwo()
    {
        textInfo = GameObject.Find("Text (2)");

        textInfo.GetComponent<Text>().text = "Zwycięstwo";

        Timer.updateON = false;

        if (Input.GetKeyDown("space"))
        {

            /*
             * TODO: koniec / nastepny level
             */
        }
    }

    public static void Porazka()
    {
        textInfo = GameObject.Find("Text (2)");
        
        Ball.updateON = false;
  

        textInfo.GetComponent<Text>().text = "Porażka, wciśnij spacje";

        if (Input.GetKeyDown("space"))
        {
            /*
           * TODO: koniec 
           */
        }
    }
    //// Use this for initialization
    //void Start () {

    //}

    //// Update is called once per frame
    //void Update () {

    //}
}
