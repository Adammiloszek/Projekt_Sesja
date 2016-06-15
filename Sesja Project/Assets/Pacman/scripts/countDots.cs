using UnityEngine;
using System.Collections;

public class countDots : MonoBehaviour {

	public static int allPacdotsCount;
	public static int currentScore;

	// Use this for initialization
	void Start () {
		allPacdotsCount = GameObject.FindGameObjectsWithTag("pacdot").Length;
		Debug.Log ("liczba wszystkich kropek" + allPacdotsCount);
	}
	
	// Update is called once per frame
	void Update () {
		int	currentPacdotsCount = GameObject.FindGameObjectsWithTag("pacdot").Length;
		currentScore = allPacdotsCount - currentPacdotsCount;
	}
}
