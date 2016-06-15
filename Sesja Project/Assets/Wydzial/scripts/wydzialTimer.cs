using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class wydzialTimer : MonoBehaviour {

	public float timeLeft = 300.0f;
	public Text textarea;
    public Text warningMessage;

    // Use this for initialization
    void Start () {

	}

	void Update()
	{
			timeLeft -= Time.deltaTime;
			textarea.text = Mathf.Round(timeLeft).ToString();
            int timeCounterInt = System.Int32.Parse(textarea.text);
            if (timeCounterInt <= 10 && timeCounterInt >= 0)
            {
                warningMessage = gameObject.GetComponent<Text>();
                warningMessage.text = "O nie! Nie zdążysz na egzamin! Pospiesz się!";
            }
            else if (timeLeft < 0)
			{
                LastScene.myLastScene = Application.loadedLevelName;
				Application.LoadLevel("Credits");
			}
            else
            {
                return;
            }
	}
}
