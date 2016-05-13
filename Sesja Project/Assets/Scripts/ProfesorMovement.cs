using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ProfesorMovement : MonoBehaviour {

    public Transform Profesor;
    public int speed=5;
    public Transform[] Points;
    Transform point;
    bool onPoint=false;
    bool readyToMove = true;
    float step;
    List<Transform> listPoints= new List<Transform>();





    void Start()
    {
        step = speed * Time.deltaTime;
        point = Points[0];

    }
    void Update ()
    {
        
        
        if (point.position == Profesor.position)
        {
            
            NewPoint();
            RotateToward();
            readyToMove = true;
        }
        else
        {
            if (readyToMove)
            {
                Profesor.position = Vector3.MoveTowards(Profesor.position, point.position, step);
            }
        }
	}
    void RotateToward()
    {


    }

    void NewPoint()
    {
        
        listPoints.Clear();
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
        }
        point = listPoints[Random.Range(0, listPoints.Count)];
        
    }
}
