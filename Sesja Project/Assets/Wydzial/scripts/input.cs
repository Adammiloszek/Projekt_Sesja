using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class input : MonoBehaviour {

    public GameObject postac;
    public float speed = 0.1f;

    public float timeLeftYou = 300.0f;
    public bool stopCounter = true;
    private float minutesToGo;
    private float secondsToGo;
    public Text timeCounter;

    private static List<string> sceneTab = new List<string> { "classroom_startowa", "scena_startowa", "pacman" };

    public List<string> SceneTab
    {
        get { return sceneTab; }
        set { sceneTab = value; }
    }


    public void StartTimer(float from)
    {
        stopCounter = false;
        timeLeftYou = from;
        UpdateTimer();
        StartCoroutine(updateCoroutine());
    }

    void UpdateTimer()
    {
        if (stopCounter)
        {
            return;
        }

        timeLeftYou -= Time.deltaTime;
        minutesToGo = Mathf.Floor(timeLeftYou / 60);
        secondsToGo = timeLeftYou % 60;

        if (secondsToGo > 59)
        {
            secondsToGo = 59;
        }  

        if (minutesToGo < 0)
        {
            stopCounter = true;
            minutesToGo = 0;
            secondsToGo = 0;
        }
    }

    private IEnumerator updateCoroutine()
    {
        while (!stopCounter)
        {
            timeCounter = gameObject.GetComponent<Text>();
            timeCounter.text = string.Format("{0:0}:{1:00}", minutesToGo, secondsToGo);
            yield return new WaitForSeconds(0.2f);
        }
    }
    
    void Start ()
    {

        // Rozpoczynamy nową grę - resetujemy ustawienia.
        if (LastScene.myLastScene == "Menu_Scene")
        {
            // czysczenie listy dostępnych scen
            SceneTab = new List<string> { "classroom_startowa", "scena_startowa", "pacman" };

            // czyszczenie statystyk
                // --- odbywa sie w Stats_Changing w Start();

            // czyszczenie arkanoida
            Timer.StartTime = 45;
            Timer.SetTimer = 0;
            CheckResult.UpdateON = true;
            Timer.UpdateON = true;
            Timer.SetTimer = 0;
            Timer.StartTime = 45;
            Main.Podejscia = 2;
            Main.Punkty = 0;
            Main.Zycia = 3;
            Main.Bloki = 0;
                

            // czyszczenie pacmana
            GhostMovePathInCode.Podejscia = 2;

            // czyszczenie classroom
            FovController.Podejscia = 2;
        }

        if (sceneTab.Count == 0)
        {
            Debug.Log("GAME COMPLETED");
            Application.LoadLevel("CreditsWin");
        }

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "bonus")
        {
            Destroy(coll.gameObject);
            StartTimer(300);
            //tutaj dodaj so jeszcze ma się dziać kiedy wejdziemy w bonus
            //na razie jedynie zostaje zniszczony :O
        }

        if (coll.gameObject.name == "portal")
        {
            System.Random rand = new System.Random();

            string tmp = sceneTab[rand.Next(0, sceneTab.Count)];

            sceneTab.Remove(tmp);

            Application.LoadLevel(tmp);

        }

    }


    void FixedUpdate () {
        if (Input.GetKey("up"))
            postac.GetComponent<Transform>().transform.position += new Vector3(0, speed, 0);

        if (Input.GetKey("down"))
            postac.GetComponent<Transform>().transform.position -= new Vector3(0, speed, 0);

        if (Input.GetKey("left"))
            postac.GetComponent<Transform>().transform.position -= new Vector3(speed, 0, 0);

        if (Input.GetKey("right"))
            postac.GetComponent<Transform>().transform.position += new Vector3(speed, 0, 0);
	}
}
