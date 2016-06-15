using UnityEngine;
using System.Collections;

public class CreateGoodAndBadGuys : MonoBehaviour
{
	public GameObject goodGuy;
	public GameObject badGuy;

	int connection = Stats.Connections;
	int knowledge = Stats.Knowledge;

	IEnumerator WaitForGoodGuy ()
	{
		Debug.Log ("waiting for goodGuy"); 
		yield return new WaitForSeconds (15 - connection);
		Debug.Log ("bum good guy appears");

		// lewy dolny róg : (1.93f, 2.27f)
		// prawy dolny róg: (27f, 2f)
		// lewy górny róg: (1.89f, 30f)
		// prawy górny róg: (27f, 30f)

		GameObject[] pacdots = GameObject.FindGameObjectsWithTag ("pacdot");

		if (pacdots != null && pacdots.Length > 0) {
			GameObject randomPacdot = pacdots [Random.Range (0, pacdots.Length)];
	
			if (pacdots.Length > 30) {
				Instantiate (goodGuy, randomPacdot.transform.position, Quaternion.identity);
				Destroy (randomPacdot);  
			}
		}

	}



	public	void LaunchWaitForBadGuy ()
	{
		Debug.Log ("in Launch waiting for BadGuy");
		StartCoroutine (WaitForBadGuy ());
	}


	public	void LaunchWaitForGoodGuy ()
	{
		Debug.Log ("in Launch waiting for goodGuy");
		StartCoroutine (WaitForGoodGuy ());
	}


	IEnumerator WaitForBadGuy ()
	{
		Debug.Log ("waiting for BadGuy"); 
		yield return new WaitForSeconds (15 + connection - knowledge);
		Debug.Log ("bum bad guy appears");

		GameObject[] pacdots = GameObject.FindGameObjectsWithTag ("pacdot");
	
		if (pacdots != null && pacdots.Length > 0) {
			GameObject randomPacdot = pacdots [Random.Range (0, pacdots.Length)];

			if (pacdots.Length > 30 && pacdots.Length > 0) {
				Instantiate (badGuy, randomPacdot.transform.position, Quaternion.identity);
				Destroy (randomPacdot);
			}
		}
	}
		

	// Use this for initialization
	void Start ()
	{
		Debug.Log ("start creating in 3s or 5s");
		InvokeRepeating ("LaunchWaitForBadGuy", 3, 15F);
		InvokeRepeating ("LaunchWaitForGoodGuy", 5, 7F);
	}
		
}
