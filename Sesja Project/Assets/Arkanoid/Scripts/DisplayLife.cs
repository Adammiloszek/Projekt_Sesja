using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayLife : MonoBehaviour {

    public Text komponent;
    int zycia = Main.Zycia;

    void Start()
    {
        komponent = GetComponent<Text>();
        komponent.text = zycia.ToString();
    }

    void Update()
    {
        zycia = Main.Zycia;
        komponent.text = zycia.ToString();
    }
}
