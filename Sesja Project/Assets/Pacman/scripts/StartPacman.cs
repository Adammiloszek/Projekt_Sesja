using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartPacman : MonoBehaviour
{

    string scena;

    // Use this for initialization
    void Start()
    {

        scena = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("return"))
        {
            if (scena == "startowa" || scena == "powtorka")
                SceneManager.LoadScene("pacman");
            else if (scena == "pacman")
                SceneManager.LoadScene("umrzyj");
            else if (scena == "umrzyj")
            {
                LastScene.myLastScene = Application.loadedLevelName;
                Application.LoadLevel("Credits");
            }
        }
    }
}
