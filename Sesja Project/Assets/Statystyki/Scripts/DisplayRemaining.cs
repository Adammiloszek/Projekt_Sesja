using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayRemaining : MonoBehaviour {

    public Text komponent;
    int punkty = Stats.Remaining;

    void Start()
    {
        komponent = GetComponent<Text>();
        komponent.text = punkty.ToString();
    }

    void Update()
    {
        punkty = Stats.Remaining;
        komponent.text = punkty.ToString();
    }
}
