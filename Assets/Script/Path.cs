using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path
{
    // Route nodes
    public Vector3[] wayPoints;
    //Index of route nodes now
    public int index = -1;
    //current node routes
    public Vector3 wayPoint;

    public bool isLoop = false;
    //
    public float deviation = 2;
    //completed or not.
    public bool isFinish = false;
    
    //Arrived or not.
    public bool isReach(Transform player) 
    {
        Vector3 pos = player.position;
        float distance = Vector3.Distance(wayPoint, pos);
        return distance < deviation;
    }

    //next route node
    public void nextWayPoint() 
    {
        if (index < 0)
            return;
        if (index < wayPoints.Length - 1)
        {
            index++;
        }
        else 
        {
            if (isLoop)
                index = 0;
            else
                isFinish =  true;
        }
        wayPoint = wayPoints[index];
    }
    //Generate route node by Scene identification
    public void initByObj(GameObject obj, bool isLoop = false)
    {
        int length = obj.transform.childCount;
        //If 
        if (length == 0) 
        {
            wayPoints = null;
            index = -1;
            Debug.Log("No way points now!");
            return;
        }
        //遍历子物体生成路店
        wayPoints = new Vector3[length];
        int i = 0;
        while (i < length) 
        {
            Transform trans = obj.transform.GetChild(i);
            wayPoints[i] = trans.position;
            i++;
        }
        //Set some variables
        index = 0;
        wayPoint = wayPoints[index];
        this.isLoop = isLoop;
        isFinish = false;
    }
}
