using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class umrzenie : MonoBehaviour {

    Text komponent;
    

    void Start()
    {
        komponent = GetComponent<Text>();
        komponent.text = "Punkty: " + pacdot.punkty.ToString();
    }

    void Update()
    {
        float punkty = pacdot.punkty;
        float proc = punkty / 320;
        string ocena = "2";
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
        komponent.text = "Uzyskałeś " + punkty.ToString() + "/320 punktów z egzaminu. Twoja ocena to " + ocena + ".";
    }
}
