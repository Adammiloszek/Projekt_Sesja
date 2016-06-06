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

		// lewy dolny róg : (-5.5f, -3.8f)
		// prawy dolny róg: (19.4f, -3.8f)
		// lewy górny róg: (-5.5f, 24f)
		// prawy górny róg: (19.4f, 24f)

		Random random = new Random ();

		Vector2 randomVector = new Vector2 (Random.Range (-5.5f+7.54f, 19.4f+5.8f), Random.Range (-3.8f+7.54f, 24.0f+5.8f));



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
		Vector2 randomVector = new Vector2 (Random.Range (-5.5f+7.54f, 19.4f+5.8f), Random.Range (-3.8f+7.54f, 24.0f+5.8f));



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
