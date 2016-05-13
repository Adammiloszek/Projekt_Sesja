using UnityEngine;
<<<<<<< HEAD
=======
using System.Collections;
>>>>>>> origin/Classroom
using UnityEngine.UI;

public class playerController : MonoBehaviour {

<<<<<<< HEAD
    public float cheatingSpeed = 0.02f;
=======
>>>>>>> origin/Classroom
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
<<<<<<< HEAD
        if (studentInRange == true) currentPoints += cheatingSpeed;
=======
        if (studentInRange == true) currentPoints += 0.02f;
>>>>>>> origin/Classroom
        slider.value = currentPoints;
    }
}
