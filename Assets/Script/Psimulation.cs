using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Psimulation : MonoBehaviour
{
    Path path = new Path();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Walk
        if (path.isReach(transform)) 
        {
            path.nextWayPoint();
        }
    }
    //
    void initWaypoint() 
    {
        GameObject obj = GameObject.Find("WaypointCentre");
        if (obj)
            path.initByObj(obj);
    }
}