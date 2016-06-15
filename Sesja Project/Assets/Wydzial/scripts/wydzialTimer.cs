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

        if (timeLeft <= 10.0f)
        {
            textarea.text += "\t Zaraz koniec czasu!";
                
            if (timeLeft <= 0.0f)
            {
                LastScene.myLastScene = Application.loadedLevelName;
                Application.LoadLevel("Credits");
            }
        }
            
	}
}
