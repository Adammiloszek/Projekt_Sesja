using UnityEngine;
using System.Collections;

public class CreateGoodAndBadGuys : MonoBehaviour {

		public GameObject goodGuy;
		public GameObject badGuy;

		public int connection; // w zaleznosci od znajomosci
		public int knowledge; // i od wiedzy


	IEnumerator WaitForGoodGuy ()
	{

		Debug.Log ("waiting for goodGuy"); 

		yield return new WaitForSeconds (5 - connection);

		Debug.Log ("bum good guy appears");

		// lewy dolny róg : (1.93f, 2.27f)
		// prawy dolny róg: (27f, 2f)
		// lewy górny róg: (1.89f, 30f)
		// prawy górny róg: (27f, 30f)

		Random random = new Random ();

		Vector2 randomVector = new Vector2 (Random.Range (1.93f, 27f), Random.Range (2.27f, 30f));



		Instantiate(goodGuy, randomVector, Quaternion.identity);


	}
		


	public	void LaunchWaitForBadGuy() {
		Debug.Log("in Launch waiting");
		StartCoroutine( WaitForBadGuy());
	}


	IEnumerator WaitForBadGuy ()
	{


		Debug.Log ("waiting for BadGuy"); 

		yield return new WaitForSeconds (5 + connection - knowledge);

		Debug.Log ("bum bad guy appears");
		Vector2 randomVector = new Vector2 (Random.Range (1.93f, 27f), Random.Range (2.27f, 30f));



		Instantiate(badGuy, randomVector, Quaternion.identity);

	}




		// Use this for initialization
		void Start () {
		Debug.Log ("start creating in 3s");
		InvokeRepeating("LaunchWaitForBadGuy", 3, 15F);


			

			






		}

		// Update is called once per frame
		void Update () {

		}









}
