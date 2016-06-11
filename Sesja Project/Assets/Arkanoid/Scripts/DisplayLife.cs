using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayLife : MonoBehaviour {

    Text komponent;
    int zycia = Main.Zycia;

    void Start()
    {
        komponent = GetComponent<Text>();
        komponent.text = "Życia: " + zycia.ToString();
    }

    void Update()
    {
        zycia = Main.Zycia;
        komponent.text = "Życia: " + zycia.ToString();
    }
}
