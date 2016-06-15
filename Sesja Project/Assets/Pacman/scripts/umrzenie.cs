using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class umrzenie : MonoBehaviour {

	public static string ocena = "2";

    Text komponent;
    

    void Start()
    {
        komponent = GetComponent<Text>();
		komponent.text = "Punkty: " + countDots.currentScore.ToString ();
    }

    void Update()
    {
		float punkty = countDots.currentScore;
		float proc = punkty / countDots.allPacdotsCount;
		string punktyAsString = punkty.ToString ();
       
        if (proc > 0.5)
            ocena = "3";
        if (proc > 0.6)
            ocena = "3,5";
        if (proc > 0.7)
            ocena = "4";
        if (proc > 0.8)
            ocena = "4,5";
        if (proc > 0.9)
            ocena = "5";
		komponent.text = "Uzyskałeś " + punktyAsString + " / " + countDots.allPacdotsCount.ToString() + "punktów z egzaminu. Twoja ocena to " + ocena + ".";
    }
}
