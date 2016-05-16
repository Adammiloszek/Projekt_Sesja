using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ProfesorMovement : MonoBehaviour {

    public Transform Profesor;
    public float speed=1;
    //public float rotationSpeed = 2.0f;
    public Transform[] Points;


    private Quaternion _lookRotation;
    private Vector3 _direction;
    Transform point;
    bool onPoint=false;
    bool readyToMove = true;
    int waiting=0;
    float step;
    List<Transform> listPoints= new List<Transform>();
    int direction;





    void Start()
    {
        step = speed * Time.deltaTime;
        point = Points[0];
        RotateToward();

    }
    void Update()
    {
        if (point.position == Profesor.position)
        {
            Profesor.position = point.position;
            onPoint = true;
            NewPoint();
            readyToMove = false;

            RotateToward();


            StartCoroutine(WaitCoroutine());
        }
        
        if (onPoint)
        {

            if (waiting <= 360/2)
            {
                waiting++;
                Profesor.localRotation = Quaternion.Euler(new Vector3(2*waiting, 90, 90));
            }

            if (waiting > 360 / 2  && waiting-180 < direction*90)
            {
                waiting++;
                Profesor.localRotation = Quaternion.Euler(new Vector3(2 * waiting, 90, 90));
            }
        }
        else
        {
            if (readyToMove)
            {
                waiting = 0;
                Profesor.position = Vector3.MoveTowards(Profesor.position, point.position, step);
                
            }
        }
	}

    void MLG360NoScope()
    {
        
        
    }

    IEnumerator WaitCoroutine()
    {
        yield return new WaitForSeconds(4.0f);
        readyToMove = true;
        onPoint = false;
        RotateToward();
    }

    void RotateToward()
    {


        Debug.Log(Profesor.position +"  "+ point.position );

        if (Profesor.position.x > point.position.x ) { Profesor.localRotation = Quaternion.Euler(new Vector3(180, 90, 90)); direction = 2; }
        if (Profesor.position.x < point.position.x ) { Profesor.localRotation = Quaternion.Euler(new Vector3(0, 90, 90)); direction = 0; }
        if (Profesor.position.y < point.position.y) { Profesor.localRotation = Quaternion.Euler(new Vector3(-90, 90, 90)); direction = 3; }
            if (Profesor.position.y > point.position.y) { Profesor.localRotation = Quaternion.Euler(new Vector3(90, 90, 90)); direction = 1; }

        //_direction = (point.position - transform.position).normalized;
        //_lookRotation = Quaternion.LookRotation(_direction);
        //transform.rotation = Quaternion.Slerp(transform.rotation, _lookRotation, Time.deltaTime * 1000);

    }

    void NewPoint()
    {
        
        listPoints.Clear();

        foreach (Transform item in Points)
        {
            if (item.position.x==point.position.x || item.position.y == point.position.y)
            {
                listPoints.Add(item);
            }
        }
        point = listPoints[Random.Range(0, listPoints.Count)];
        
    }
}
