using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public static class Main  {

    private static int podejscia = 2;

    private static int punkty = 0;

    private static int zycia = 3;

    private static int bloki = 0;

    private static GameObject textInfo;

    private static GameObject textKlawisz;

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

        textKlawisz = GameObject.Find("klawiszInfo");

        racket = GameObject.Find("racket");

        ball = GameObject.Find("ball");


        textKlawisz.GetComponent<Text>().text = "wciśnij SPACJĘ";

        if (Input.GetKeyDown("space"))
        {
            zycia--;

            if(zycia >= 0)
            {

              

                //ustaw podstawke
                racket.GetComponent<Rigidbody2D>().transform.position = new Vector2(-0.2f, -98.7f);

                //ustaw pilke i ruch piłki
                ball.GetComponent<Rigidbody2D>().velocity = Vector2.up * 200;
                ball.GetComponent<Rigidbody2D>().transform.position = new Vector2(-1.8f, -74);

                textKlawisz.GetComponent<Text>().text = "";

                

                Ball.ChooseBallPosition = true;
            }
            else
            {

                Porazka();
               
            }
        }
    }

  public static void Zwyciestwo(int wynik, double ocena)
    {
        textInfo = GameObject.Find("Text (2)");
        textKlawisz = GameObject.Find("klawiszInfo");

        

        textInfo.GetComponent<Text>().text = "Zaliczyłeś! :) Twój wynik to " + punkty + "/1200. Twoja ocena to " + ocena;
        textKlawisz.GetComponent<Text>().text = "wciśnij ENTER";

        Timer.UpdateON = false;

        if (Input.GetKeyDown("return"))
        {
            zycia = 3;
            punkty = 0;
            bloki = 0;
            podejscia = 2;
            Ball.ChooseBallPosition = true;
            textKlawisz.GetComponent<Text>().text = "wciśnięto";
            CheckResult.UpdateON = false;


            /*
            * TODO: zwyciestwo, koniec, egzamin zaliczony
            * SceneManager.LoadScene("");
            */

        }
    }

    public static void Porazka()
    {
        textInfo = GameObject.Find("Text (2)");
        textKlawisz = GameObject.Find("klawiszInfo");

        string aktywnaScena = SceneManager.GetActiveScene().name;

        Ball.UpdateON = false;



        
        



        if (podejscia == 2)
            textInfo.GetComponent<Text>().text = "Nie zaliczyłeś, Twój wynik to " + punkty + "/1200, Twoja ocena to 2 :( , ale na szczęście jest II termin :)";
        else
            textInfo.GetComponent<Text>().text = "Nie zaliczyłeś, Twój wynik to " + punkty + "/1200, Twoja ocena to 2 :( , III terminu już nie ma :(";

        textKlawisz.GetComponent<Text>().text = "wciśnij ENTER";

        
        if (Input.GetKeyDown("return"))
        {
            podejscia--;

            if (podejscia == 1)
            {
                Timer.UpdateON = false;
                zycia = 3;
                punkty = 0;
                bloki = 0;
                Ball.ChooseBallPosition = true;
                SceneManager.LoadScene("scena");
                    
            }
            else
            {
                Timer.UpdateON = false;
                textKlawisz.GetComponent<Text>().text = "wciśnięto";
                zycia = 3;
                punkty = 0;
                bloki = 0;
                Ball.ChooseBallPosition = true;
                podejscia = 2;
                CheckResult.UpdateON = false;
                /*
                * TODO: porażka koniec, egzamin niezaliczony
                 * SceneManager.LoadScene("");
                 * 
                 * 
                */
            }

        }
        
        
    }

    public static void KoniecCzasu(bool b1, bool b2)
    {
        textInfo = GameObject.Find("Text (2)");
        textKlawisz = GameObject.Find("klawiszInfo");

        string aktywnaScena = SceneManager.GetActiveScene().name;

        Ball.UpdateON = false;
        if(b2)
            Timer.UpdateON = false;

        if (zycia == 0 && !b1)
        {
            textInfo.GetComponent<Text>().text = "Niestety zostałeś przyłapany na ściąganiu...";
        }
        else if (aktywnaScena == "scena" && b2)
        {
            textInfo.GetComponent<Text>().text = "Nieźle! Rozwiązałeś I zadanie przed końcem czasu! :)";
        }
        else if (aktywnaScena == "scena")
        {
            textInfo.GetComponent<Text>().text = "Czas na I zadanie się skończył, pora na następne...";
        }
        else if (aktywnaScena == "scena1" && b2)
        {
            textInfo.GetComponent<Text>().text = "Świetnie! Rozwiązałeś II zadanie przed końcem czasu! :)";
        }
        else if (aktywnaScena == "scena1")
        {
            textInfo.GetComponent<Text>().text = "Czas na II zadanie się skończył, pora na III...";
        }
        else if (aktywnaScena == "scena2" && b2)
        {
            textInfo.GetComponent<Text>().text = "Brawo! Rozwiązałeś I zadanie przed końcem czasu! :) Za chwilę poznasz wynik egzaminu...";
        }
        else if (aktywnaScena == "scena2")
        {
            textInfo.GetComponent<Text>().text = "Koniec egzaminu, za chwilę poznasz wynik...";
        }

        textKlawisz.GetComponent<Text>().text = "wciśnij ENTER";



        if (Input.GetKeyDown("return"))
        {
            bloki = 0;
            Timer.UpdateON = false;
            if (zycia == 0 && !b1)
            {
                zycia--;
                SceneManager.LoadScene("scena_koncowa");
            }
            else if (aktywnaScena == "scena")
            {
                Ball.ChooseBallPosition = true;
                SceneManager.LoadScene("scena1");
            }
            else if (aktywnaScena == "scena1")
            {
                Ball.ChooseBallPosition = true;
                SceneManager.LoadScene("scena2");
            }
            else if (aktywnaScena == "scena2")
            {
                Timer.UpdateON = false;
                SceneManager.LoadScene("scena_koncowa");
            }
        }
    }




    //public static void Zwyciestwo()
    //{
    //    textInfo = GameObject.Find("Text (2)");
    //    textKlawisz = GameObject.Find("klawiszInfo");

    //    textInfo.GetComponent<Text>().text = "Zaliczyłeś! :)";
    //    textKlawisz.GetComponent<Text>().text = "wciśnij SPACJĘ";

    //    Timer.UpdateON = false;

    //    if (Input.GetKeyDown("space"))
    //    {

    //        if (SceneManager.GetActiveScene().name == "scena")
    //        {
    //            Ball.ChooseBallPosition = true;
    //            SceneManager.LoadScene("scena1");
    //        }
    //        if (SceneManager.GetActiveScene().name == "scena1")
    //        {
    //            Ball.ChooseBallPosition = true;
    //            SceneManager.LoadScene("scena2");
    //        }
    //        if (SceneManager.GetActiveScene().name == "scena2")
    //        {
    //            Ball.UpdateON = false;
    //            textKlawisz.GetComponent<Text>().text = "wciśnięto";
    //            /*
    //            * TODO: zwyciestwo, koniec, egzamin zaliczony
    //            */
    //        }

    //    }
    //}

    //public static void Porazka()
    //{
    //    textInfo = GameObject.Find("Text (2)");
    //    textKlawisz = GameObject.Find("klawiszInfo");

    //    Ball.UpdateON = false;

    //    if (podejscia == 2)
    //        textInfo.GetComponent<Text>().text = "Niezaliczyłeś :( , ale na szczęście jest II termin :)";
    //    else
    //        textInfo.GetComponent<Text>().text = "Niezaliczyłeś :( , III terminu już nie ma :(";

    //    textKlawisz.GetComponent<Text>().text = "wciśnij ENTER";

        
    //    if (Input.GetKeyDown("return"))
    //    {
    //        podejscia--;


    //        //for debug
    //        //textInfo.GetComponent<Text>().text = "wciesnieto";

    //        if (podejscia == 1)
    //        {
    //            Timer.UpdateON = false;
    //            zycia = 3;
    //            punkty = 0;
    //            bloki = 0;
    //            Ball.ChooseBallPosition = true;
    //            SceneManager.LoadScene("scena");
                    
                    
    //            //Ball.UpdateON = true;
    //            //Timer.ResetTimer();
    //            //Application.LoadLevel("scena");
                    
                    
    //        }
    //        else
    //        {
    //            Timer.UpdateON = false;
    //            textKlawisz.GetComponent<Text>().text = "wciśnięto";
    //            zycia = 3;
    //            punkty = 0;
    //            bloki = 0;
    //            Ball.ChooseBallPosition = true;
    //            podejscia = 2;
                
    //        /*
    //        * TODO: porażka koniec, egzamin niezaliczony
    //        */
    //        }

    //    }
  
}
