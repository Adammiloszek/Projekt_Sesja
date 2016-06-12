using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class input : MonoBehaviour {

    public GameObject postac;
    public float speed = 0.1f;

    public float timeLeftYou = 300.0f;
    public bool stopCounter = true;
    private float minutesToGo;
    private float secondsToGo;
    public Text timeCounter;

    public void StartTimer(float from)
    {
        stopCounter = false;
        timeLeftYou = from;
        UpdateTimer();
        StartCoroutine(updateCoroutine());
    }

    void UpdateTimer()
    {
        if (stopCounter)
        {
            return;
        }

        timeLeftYou -= Time.deltaTime;
        minutesToGo = Mathf.Floor(timeLeftYou / 60);
        secondsToGo = timeLeftYou % 60;

        if (secondsToGo > 59)
        {
            secondsToGo = 59;
        }  

        if (minutesToGo < 0)
        {
            stopCounter = true;
            minutesToGo = 0;
            secondsToGo = 0;
        }
    }

    private IEnumerator updateCoroutine()
    {
        while (!stopCounter)
        {
            timeCounter = gameObject.GetComponent<Text>();
            timeCounter.text = string.Format("{0:0}:{1:00}", minutesToGo, secondsToGo);
            yield return new WaitForSeconds(0.2f);
        }
    }

    // Use this for initialization
    void Start ()
    {

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "bonus")
        {
            Destroy(coll.gameObject);
            StartTimer(300);
            //tutaj dodaj so jeszcze ma się dziać kiedy wejdziemy w bonus
            //na razie jedynie zostaje zniszczony :O
        }
    }


    void FixedUpdate () {
        if (Input.GetKey("up"))
            postac.GetComponent<Transform>().transform.position += new Vector3(0, speed, 0);

        if (Input.GetKey("down"))
            postac.GetComponent<Transform>().transform.position -= new Vector3(0, speed, 0);

        if (Input.GetKey("left"))
            postac.GetComponent<Transform>().transform.position -= new Vector3(speed, 0, 0);

        if (Input.GetKey("right"))
            postac.GetComponent<Transform>().transform.position += new Vector3(speed, 0, 0);
	}
}
