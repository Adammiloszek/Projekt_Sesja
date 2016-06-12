using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour {

    string scena;

	// Use this for initialization
	void Start () {

        scena = SceneManager.GetActiveScene().name;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("return"))
        {
            if (scena == "scena_startowa")
                SceneManager.LoadScene("scena_startowa2");
            else if (scena == "scena_startowa2")
                SceneManager.LoadScene("scena_startowa3");
            else if (scena == "scena_startowa3")
                SceneManager.LoadScene("scena");
        }
	}
}
