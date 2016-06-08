using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour {

    public static float timer = 60;
    static float bonusTime;

     public static bool updateON;

    // Use this for initialization
    void Start () {
        bonusTime = Stats.Connections * 5;
        timer += bonusTime;

        updateON = true;
    }
	
	// Update is called once per frame
	void Update () {

        if (updateON)
        {
            timer -= Time.deltaTime;
            Debug.Log(timer);

            GameObject textInfo = GameObject.Find("Text (3)");

            textInfo.GetComponent<Text>().text = Convert.ToString(timer);

            if (timer <= 0)
            {
                textInfo.GetComponent<Text>().text = "Koniec czasu";
                updateON = false;
                Main.Porazka();
            }
        }
       
    }

    public static void ResetTimer()
    {
        timer = 60;
        timer += bonusTime;
        updateON = true;
    }
}
