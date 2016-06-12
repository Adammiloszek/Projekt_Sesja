using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour {

    //private const float startTime = 45;

    private static float startTime = 45;
    private static float timer = 0;
    private static float bonusTime;

    public static float StartTime
    {
        get { return startTime; }
        set { startTime = value; }
    }

    public static float SetTimer
    {
        get { return timer; }
        set { timer = value; }
    }

    private static bool updateON;

    public static bool UpdateON
    {
        get { return updateON; }
        set { updateON = value; }
    }

    // Use this for initialization
    void Start () {

        timer = startTime;
        bonusTime = Stats.Connections * 2;
        timer += bonusTime;

        GameObject textInfo = GameObject.Find("Text (3)");

        string s = Convert.ToString(timer);
        s += ".0000";
        char[] tab = s.ToCharArray();
        s = new string(tab, 0, 5);

        textInfo.GetComponent<Text>().text = "Czas: " + s;

        //updateON = true;
    }
	
	// Update is called once per frame
	void Update () {

        if (updateON)
        {
            timer -= Time.deltaTime;

            GameObject textInfo = GameObject.Find("Text (3)");

            string s = Convert.ToString(timer);
            s += "00000";
            char[] tab = s.ToCharArray();
            s = new string(tab, 0, 5);

            textInfo.GetComponent<Text>().text = "Czas: " + s;

            if (timer <= 0)
            {
                textInfo.GetComponent<Text>().text = "Koniec czasu";
                //updateON = false;
                Main.KoniecCzasu(true, false);
            }
        }
       
    }

    public static void ResetTimer()
    {
        //timer = 60;
        //timer += bonusTime;
        updateON = true;
    }
}
