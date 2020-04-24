using UnityEngine;
using System.Collections;

public class Map04 : IMapData {
	Vector3[] cubePos = new Vector3[]{
		new Vector3(3,0,7),
		new Vector3(3,0,6),
		new Vector3(3,0,5),
		new Vector3(3,0,4),
		new Vector3(3,0,3),
		new Vector3(3,0,2),
		new Vector3(3,0,1),
		new Vector3(3,0,0),

        new Vector3(3,1,0),
		new Vector3(3,2,0),
		new Vector3(3,3,0),
        new Vector3(3,4,0),
        new Vector3(3,5,0),
        new Vector3(3,6,0),
        new Vector3(3,6,-1),
        //new Vector3(7,6,4),
        //new Vector3(6,6,4),
        //new Vector3(5,6,4),
        //new Vector3(4,6,4),
        //new Vector3(3,6,4),
        //new Vector3(2,6,4),
        //new Vector3(1,6,4),
        //new Vector3(0,6,4),
		new Vector3(-1,6,4),
		new Vector3(-2,6,4),
		new Vector3(-3,6,4),
		new Vector3(-3,6,3),
		new Vector3(-3,6,2),
        new Vector3(-5,4,5),
        new Vector3(-6,4,5),
        new Vector3(-7,4,5),
        new Vector3(7,3,3),
        new Vector3(3,6,-2),
        new Vector3(3,6,-3),
	};
	
	Vector3[] slopePos = new Vector3[]{
        new Vector3(4,1,3),
        new Vector3(5,2,3),
        new Vector3(6,3,3),

        new Vector3(4,0,3),
        new Vector3(5,1,3),
        new Vector3(6,2,3),

		new Vector3(7,4,4),
		new Vector3(7,5,5),
		new Vector3(7,6,6),

		new Vector3(7,3,4),
		new Vector3(7,4,5),
		new Vector3(7,5,6),

		new Vector3(-3,6,4),
        		new Vector3(-3,6,1),
	};
	
	Quaternion[] slopeRot = new Quaternion[]{
        Quaternion.Euler(0,0,0),
        Quaternion.Euler(0,0,0),
        Quaternion.Euler(0,0,0),

        Quaternion.Euler(0,0,180),
        Quaternion.Euler(0,0,180),
        Quaternion.Euler(0,0,180),

		Quaternion.Euler(0,270,0),
		Quaternion.Euler(0,270,0),
		Quaternion.Euler(0,270,0),

		Quaternion.Euler(0,270,180),
		Quaternion.Euler(0,270,180),
		Quaternion.Euler(0,270,180),

		Quaternion.Euler(0,270,90),
        		Quaternion.Euler(0,270,90),
	};
	
RotatingObject[] rotObj = new RotatingObject[]
    {
        new RotatingObject("C360", new Vector3(0, 7, 0), new Vector3(0, 0, 1)),
        new RotatingObject("C350", new Vector3(0, 7, 0), new Vector3(0, 0, 1)),
        new RotatingObject("C340", new Vector3(0, 7, 0), new Vector3(0, 0, 1)),
        new RotatingObject("C330", new Vector3(0, 7, 0), new Vector3(0, 0, 1)),
        new RotatingObject("C320", new Vector3(0, 7, 0), new Vector3(0, 0, 1)),
        new RotatingObject("C310", new Vector3(0, 7, 0), new Vector3(0, 0, 1)),
        new RotatingObject("C300", new Vector3(0, 7, 0), new Vector3(0, 0, 1)),
        new RotatingObject("C301", new Vector3(0, 7, 0), new Vector3(0, 0, 1)),
        new RotatingObject("C302", new Vector3(0, 7, 0), new Vector3(0, 0, 1)),
        new RotatingObject("C303", new Vector3(0, 7, 0), new Vector3(0, 0, 1)),
        new RotatingObject("C304", new Vector3(0, 7, 0), new Vector3(0, 0, 1)),

        //new RotatingObject("C070", new Vector3(0, 7, 0), new Vector3(0, 0, 1)),
        //new RotatingObject("C071", new Vector3(0, 7, 0), new Vector3(0, 0, 1)),
        //new RotatingObject("C072", new Vector3(0, 7, 0), new Vector3(0, 0, 1)),
        //new RotatingObject("C073", new Vector3(0, 7, 0), new Vector3(0, 0, 1)),
        //new RotatingObject("C173", new Vector3(0, 7, 0), new Vector3(0, 0, 1)),
        //new RotatingObject("C273", new Vector3(0, 7, 0), new Vector3(0, 0, 1)),
        //new RotatingObject("C373", new Vector3(0, 7, 0), new Vector3(0, 0, 1)),

    };

Vector3 playerStart = new Vector3(-5, 4, 5);
	
	public Vector3[] CubePos{ get{ return cubePos; } }
	public Vector3[] SlopePos{ get{ return slopePos; } }
	public Quaternion[] SlopeRot{ get{ return slopeRot; } }
	public RotatingObject[] RotObj{ get{ return rotObj; } }
	public Vector3 PlayerStart{ get{ return playerStart; } }

    public int Number { get { return 4; } }
}
