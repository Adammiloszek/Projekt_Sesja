using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class input : MonoBehaviour {

    public GameObject postac;
    public float speed = 0.1f;

    private static List<string> sceneTab = new List<string> { "classroom_startowa", "scena_startowa", "startowa" };

    public List<string> SceneTab
    {
        get { return sceneTab; }
        set { sceneTab = value; }
    }

    wydzialTimer counterScript;
    wydzialWarning warningBox;

    void Start ()
    {
        // init timer
        GameObject counter = GameObject.Find("timeCounter");
        counterScript = counter.GetComponent<wydzialTimer>();
        GameObject warning = GameObject.Find("Text");
        warningBox = warning.GetComponent<wydzialWarning>();
        counterScript.timeLeft = 20.0f;
        warningBox.Text.text = "";
        Global.ifT = false;

        // Rozpoczynamy nową grę - resetujemy ustawienia.
        if (LastScene.myLastScene == "Menu_Scene")
        {
            // czysczenie listy dostępnych scen
            SceneTab = new List<string> { "classroom_startowa", "scena_startowa", "startowa" };

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
            counterScript.timeLeft += 10.0f;
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
