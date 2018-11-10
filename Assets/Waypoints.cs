using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour {

    public static Transform[] points;

     void Awake() //find all different objects (childrens) and load them in "points" array 
    {
        points = new Transform[transform.childCount]; //in my case count 11 waypoints so create 11 spaces in array
        for (int i = 0; i < points.Length; i++)
        {
            points[i] = transform.GetChild(i); //push those kids into the array "points" with all indexes 
        }
    }
}
 