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

        GameObject found;
        do
        {
            found = GameObject.Find("pacdot (" + Random.Range(1, 700) + ")");

        } while (found == null);
        
        Instantiate(goodGuy, found.transform.position, Quaternion.identity);
        Destroy(found);

	}
		


	public	void LaunchWaitForBadGuy() {
		Debug.Log("in Launch waiting for BadGuy");
		StartCoroutine( WaitForBadGuy());
	}


	public	void LaunchWaitForGoodGuy() {
		Debug.Log("in Launch waiting for goodGuy");
		StartCoroutine( WaitForGoodGuy());
	}


	IEnumerator WaitForBadGuy ()
	{


		Debug.Log ("waiting for BadGuy"); 

		yield return new WaitForSeconds (5 + connection - knowledge);

		Debug.Log ("bum bad guy appears");

        GameObject found;
        do
        {
            found = GameObject.Find("pacdot (" + Random.Range(1, 700) + ")");

        } while (found == null);

        Instantiate(badGuy, found.transform.position, Quaternion.identity);
        Destroy(found);

	}




		// Use this for initialization
		void Start () {
		Debug.Log ("start creating in 3s or 5s");
		InvokeRepeating("LaunchWaitForBadGuy", 3, 15F);
		InvokeRepeating("LaunchWaitForGoodGuy", 5, 7F);

			

			






		}

		// Update is called once per frame
		void Update () {

		}









}
