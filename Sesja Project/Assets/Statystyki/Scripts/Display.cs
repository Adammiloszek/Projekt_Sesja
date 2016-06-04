using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Display : MonoBehaviour {


    public Text komponent;
    int wiedza = Stats.Knowledge;
	
	void Start () {
        komponent = GetComponent<Text>();
        komponent.text = wiedza.ToString();
	}

	void Update () {
        wiedza = Stats.Knowledge;
        komponent.text = wiedza.ToString();
	}
}
