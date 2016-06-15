using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class wydzialWarning : MonoBehaviour {

    public string t = "";
    public Text Text;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        Text.text = t;
        Global.ifT = false;

        if (Global.ifT == true)
        {
            Text.text = "O nie! Spoźnisz się!";
        }
	}
}