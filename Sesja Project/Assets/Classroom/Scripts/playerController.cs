using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour {

    private float cheatingSpeed = (float)Stats.Cheating / 500f + 0.02f;
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
        if (studentInRange == true) currentPoints += cheatingSpeed;
        slider.value = currentPoints;

        if (slider.value >= slider.maxValue)
        {
            LastScene.myLastScene = Application.loadedLevelName;
            Application.LoadLevel("classroom_wygrana");
        }
    }
}
