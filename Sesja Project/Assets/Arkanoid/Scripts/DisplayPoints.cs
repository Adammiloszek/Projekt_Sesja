using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class DisplayPoints : MonoBehaviour {

    public Text komponent;
    int punkty = Main.Punkty;

    void Start()
    {
        komponent = GetComponent<Text>();
        komponent.text = punkty.ToString();
    }

    void Update()
    {
        punkty = Main.Punkty;
        komponent.text = punkty.ToString();
    }
}
