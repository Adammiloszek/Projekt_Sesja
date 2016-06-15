using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ClassroomStartScript: MonoBehaviour {

    string scena;

	// Use this for initialization
	void Start () {

        scena = SceneManager.GetActiveScene().name;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("return"))
        {
            if (scena == "classroom_startowa")
                SceneManager.LoadScene("classroom");
            else if (scena == "classroom_srodkowa")
                SceneManager.LoadScene("classroom");
            else if (scena == "classroom_koncowa")
                SceneManager.LoadScene("Credits");
            else if (scena == "classroom_wygrana")
                SceneManager.LoadScene("chodzenie");
        }
	}
}
