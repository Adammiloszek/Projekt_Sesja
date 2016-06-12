using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class DisplayPoints : MonoBehaviour {

    Text komponent;
    int punkty = Main.Punkty;

    void Start()
    {
        komponent = GetComponent<Text>();
        komponent.text = "Punkty: " + punkty.ToString();
    }

    void Update()
    {
        punkty = Main.Punkty;
        komponent.text = "Punkty: " + punkty.ToString();
    }
}
