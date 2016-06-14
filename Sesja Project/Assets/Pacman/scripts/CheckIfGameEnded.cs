using UnityEngine;
using System.Collections;

public class CheckIfGameEnded : MonoBehaviour {

    void FixedUpdate () {
	
		GameObject[] pacdots = GameObject.FindGameObjectsWithTag("pacdot");

		if (pacdots == null || pacdots.Length <= 0) {

            LastScene.myLastScene = Application.loadedLevelName;
            Application.LoadLevel("umrzyj");

		}

	}
}
