using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ProfesorMovement : MonoBehaviour {

    public Transform Profesor;
<<<<<<< HEAD
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
=======
    public int speed=5;
    public Transform[] Points;
    Transform point;
    bool onPoint=false;
    bool readyToMove = true;
    float step;
    List<Transform> listPoints= new List<Transform>();
>>>>>>> origin/Classroom





    void Start()
    {
        step = speed * Time.deltaTime;
        point = Points[0];
<<<<<<< HEAD
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
=======

    }
    void Update ()
    {
        
        
        if (point.position == Profesor.position)
        {
            
            NewPoint();
            RotateToward();
            readyToMove = true;
>>>>>>> origin/Classroom
        }
        else
        {
            if (readyToMove)
            {
<<<<<<< HEAD
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

=======
                Profesor.position = Vector3.MoveTowards(Profesor.position, point.position, step);
            }
        }
	}
>>>>>>> origin/Classroom
    void RotateToward()
    {


<<<<<<< HEAD
        Debug.Log(Profesor.position +"  "+ point.position );

        if (Profesor.position.x > point.position.x ) { Profesor.localRotation = Quaternion.Euler(new Vector3(180, 90, 90)); direction = 2; }
        if (Profesor.position.x < point.position.x ) { Profesor.localRotation = Quaternion.Euler(new Vector3(0, 90, 90)); direction = 0; }
        if (Profesor.position.y < point.position.y) { Profesor.localRotation = Quaternion.Euler(new Vector3(-90, 90, 90)); direction = 3; }
            if (Profesor.position.y > point.position.y) { Profesor.localRotation = Quaternion.Euler(new Vector3(90, 90, 90)); direction = 1; }

        //_direction = (point.position - transform.position).normalized;
        //_lookRotation = Quaternion.LookRotation(_direction);
        //transform.rotation = Quaternion.Slerp(transform.rotation, _lookRotation, Time.deltaTime * 1000);

=======
>>>>>>> origin/Classroom
    }

    void NewPoint()
    {
        
        listPoints.Clear();
<<<<<<< HEAD

        foreach (Transform item in Points)
        {
            if (item.position.x==point.position.x || item.position.y == point.position.y)
            {
                listPoints.Add(item);
            }
=======
        int index = 0;
        for (int i = 0; i < Points.Length; i++)
        {
            if (point == Points[i]) index = i;
        }
        if (index == 0) listPoints.Add(Points[1]);
        if (index == 1) listPoints.Add(Points[0]);
        if (index == 2) listPoints.Add(Points[3]);
        if (index == 3) listPoints.Add(Points[2]);
        if (index == 4) listPoints.Add(Points[5]);
        if (index == 5) listPoints.Add(Points[4]);
        for (int i = 0; i < Points.Length; i++)
        {
            if (index % 2 == i % 2) listPoints.Add(Points[i]);
>>>>>>> origin/Classroom
        }
        point = listPoints[Random.Range(0, listPoints.Count)];
        
    }
}
