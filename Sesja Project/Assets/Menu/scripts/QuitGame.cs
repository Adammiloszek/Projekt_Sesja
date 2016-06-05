using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour {

	public Button exitBtn;

	void Start () {

		exitBtn.onClick.AddListener (() => {
			Application.Quit ();
		});

	}


	
	// Update is called once per frame
	void Update () {
	
	}
}
