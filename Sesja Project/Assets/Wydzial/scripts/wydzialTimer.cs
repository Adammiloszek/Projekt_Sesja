using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class wydzialTimer : MonoBehaviour {

	public float timeLeft = 300.0f;
	public Text textarea;

    // Use this for initialization
    void Start () {

	}

	void Update()
	{
        timeLeft -= Time.deltaTime;
        textarea.text = Mathf.Round(timeLeft).ToString();
        Global.ifT = false;

        if (timeLeft <= 10.0f)
        {
            Global.ifT = true;
            if (timeLeft <= 0.0f)
            {
                Application.LoadLevel("CreditsWin");
            }
        }
    }
}
