using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerController : MonoBehaviour {

    public Slider slider;
    private bool studentInRange;
    private float currentPoints;

    // Use this for initialization
    void Start () {
        studentInRange = false;
        currentPoints = 0.0f;
	}

    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Student")
        {
            studentInRange = true;
        }
    }


    void OnTriggerExit(Collider other)
    {
        
        if (other.gameObject.tag == "Student")
        {

            studentInRange = false;
        }
    }

    // Update is called once per frame
    void Update ()
    {
        if (studentInRange == true) currentPoints += 0.02f;
        slider.value = currentPoints;
    }
}
