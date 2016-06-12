using UnityEngine;
using System.Collections;

public class LoadOnClick : MonoBehaviour {

	public void LoadScene(string level)
	{
        LastScene.myLastScene = Application.loadedLevelName;
		Application.LoadLevel (level);
	}

	public void Exit () {

		Application.Quit ();
	}

}
