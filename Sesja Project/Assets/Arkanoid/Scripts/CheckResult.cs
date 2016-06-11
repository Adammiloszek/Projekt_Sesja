using UnityEngine;
using System.Collections;

public class CheckResult : MonoBehaviour {


    int punkty;
    double ocena;
    bool zaliczone;
    static bool updateON = true;

    public static bool UpdateON
    {
        get { return updateON; }
        set { updateON = value; }
    }

	// Use this for initialization
	void Start () {

        punkty = Main.Punkty;
        zaliczone = false;

        if (punkty >= 700 && Main.Zycia >= 0)
        {
            zaliczone = true;
            ocena = 3;
            if (punkty >= 1100)
                ocena = 5;
            else if (punkty >= 1000)
                ocena = 4.5;
            else if (punkty >= 900)
                ocena = 4;
            else if (punkty >= 800)
                ocena = 3.5;
        }
	}
	
	// Update is called once per frame
	void Update () {

        if (updateON)
        {
            if (zaliczone)
                Main.Zwyciestwo(punkty, ocena);
            else
                Main.Porazka();
        }
        

	}
}
