using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayConnections : MonoBehaviour {

    public Text komponent;
    int znajomosci = Stats.Connections;

    void Start()
    {
        komponent = GetComponent<Text>();
        komponent.text = znajomosci.ToString();
    }

    void Update()
    {
        znajomosci = Stats.Connections;
        komponent.text = znajomosci.ToString();
    }
}
