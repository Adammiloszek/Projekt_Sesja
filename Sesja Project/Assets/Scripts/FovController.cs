using UnityEngine;

public class FovController : MonoBehaviour {


	void Start () {
	
	}
	

	void Update () {
	
	}
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
        }
    }
}
