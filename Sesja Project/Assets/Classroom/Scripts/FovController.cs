using UnityEngine;

public class FovController : MonoBehaviour {

    private static int podejscia = 2;

    public static int Podejscia
    {
        get { return podejscia; }
        set { podejscia = value; }
    }


    void Start () {
	
	}
	

	void Update () {
	
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            podejscia = podejscia - 1;

            if (podejscia == 1)
            {
                Application.LoadLevel("classroom_srodkowa");
            }
            else if (podejscia == 0)
            {
                Application.LoadLevel("classroom_koncowa");
            }
        }
    }
}
