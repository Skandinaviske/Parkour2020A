using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct RotatingObject
{
    public string name;
    public Vector3 point;
    public Vector3 axis;
    public bool playerRot;

    public RotatingObject(string name, Vector3 point, Vector3 axis, bool playerRot = false)
    {
        this.name = name;
        this.point = point;
        this.axis = axis;
        this.playerRot = playerRot;
    }
};
public interface IMapData
{
    Vector3[] CubePos { get; }
    Vector3[] SlopePos { get; }

    Quaternion[] SlopeRot { get; }
    RotatingObject[] RotObj { get; }
    Vector3 PlayerStart { get; }

    int Number { get; }
}
