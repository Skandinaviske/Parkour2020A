using UnityEngine;
using System.Collections;

public class Map03 : IMapData {
    Vector3[] cubePos = new Vector3[]{
        new Vector3(0,0,5),
        new Vector3(1,0,5),
        new Vector3(5,0,2),
        new Vector3(5,0,3),
        new Vector3(5,0,4),
        new Vector3(5,0,5),
        new Vector3(5,0,6),
        new Vector3(5,0,7),
        new Vector3(5,0,8),
        new Vector3(9,0,5),
        new Vector3(10,0,5),
        new Vector3(10,0,6),
        new Vector3(10,0,7),
        new Vector3(10,0,8),
        new Vector3(10,0,9),
        new Vector3(10,0,10),
        new Vector3(9,0,10),
        new Vector3(8,0,10),
        new Vector3(7,0,10),
        new Vector3(6,0,10),
        new Vector3(5,0,9),
        new Vector3(5,0,10),
        new Vector3(0,5,-4),
		new Vector3(-1,4,-4),
		new Vector3(-2,4,-4),
		new Vector3(-3,4,-4),
		new Vector3(-4,4,-4),
		new Vector3(-4,4,-3),
		new Vector3(-4,4,-2),
		new Vector3(-4,4,-1),
		new Vector3(-4,4,0),
        new Vector3(-1,5,-4),
	};
	
	Vector3[] slopePos = new Vector3[]{
	};
	
	Quaternion[] slopeRot = new Quaternion[]{
       
         };
	
	RotatingObject[] rotObj = new RotatingObject[]{
         new RotatingObject("C502", new Vector3(5,0,5), new Vector3(0, 1, 0)),
        new RotatingObject("C503", new Vector3(5,0,5), new Vector3(0, 1, 0)),
        new RotatingObject("C504", new Vector3(5,0,5), new Vector3(0, 1, 0)),
        new RotatingObject("C505", new Vector3(5,0,5), new Vector3(0, 1, 0)),
        new RotatingObject("C506", new Vector3(5,0,5), new Vector3(0, 1, 0)),
        new RotatingObject("C507", new Vector3(5,0,5), new Vector3(0, 1, 0)),
        new RotatingObject("C508", new Vector3(5,0,5), new Vector3(0, 1, 0)),
    };
	
	Vector3 playerStart = new Vector3(0, 0, 5);
	
	public Vector3[] CubePos{ get{ return cubePos; } }
	public Vector3[] SlopePos{ get{ return slopePos; } }
	public Quaternion[] SlopeRot{ get{ return slopeRot; } }
	public RotatingObject[] RotObj{ get{ return rotObj; } }
	public Vector3 PlayerStart{ get{ return playerStart; } }

    public int Number { get { return 3; } }
}
