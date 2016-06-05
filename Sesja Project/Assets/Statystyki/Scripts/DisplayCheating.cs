using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayCheating : MonoBehaviour {

    public Text komponent;
    int sciaganie = Stats.Cheating;

    void Start()
    {
        komponent = GetComponent<Text>();
        komponent.text = sciaganie.ToString();
    }

    void Update()
    {
        sciaganie = Stats.Cheating;
        komponent.text = sciaganie.ToString();
    }
}
