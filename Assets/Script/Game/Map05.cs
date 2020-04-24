using UnityEngine;
using System.Collections;

public class Map05 : IMapData {
	Vector3[] cubePos = new Vector3[]{
        new Vector3(-15,8,-13),
        new Vector3(-15,8,-12),
        new Vector3(-15,8,-11),
        new Vector3(-15,8,-10),
        new Vector3(-15,8,-9),
        new Vector3(-15,8,-8),
        new Vector3(-15,8,-7),
        new Vector3(-15,8,-6),
        new Vector3(-15,8,-5),

        new Vector3(-15,9,-5),
        new Vector3(-15,10,-5),
        new Vector3(-15,11,-5),
        new Vector3(-15,12,-5),
        new Vector3(-15,13,-5),
        new Vector3(-15,14,-5),
        new Vector3(-15,15,-5),
        new Vector3(-15,16,-5),
        new Vector3(-15,17,-5),
        new Vector3(-15,18,-5),
        new Vector3(-15,19,-5),
        new Vector3(-15,20,-5),
        new Vector3(-15,21,-5),
        new Vector3(-15,22,-5),
        new Vector3(-15,22,-6),
        new Vector3(-14,22,-5),


        new Vector3(-14,8,-11),
        new Vector3(-13,8,-11),
        new Vector3(-12,8,-11),
        new Vector3(-11,8,-11),
        new Vector3(-10,8,-11),
        new Vector3(-9,8,-11),
        new Vector3(-8,8,-11),
        new Vector3(-7,8,-11),

        new Vector3(-7,8,-4),
        new Vector3(-7,8,-5),
        new Vector3(-7,8,-6),
        new Vector3(-7,8,-7),
        new Vector3(-6,8,-7),
        new Vector3(-5,8,-7),
        new Vector3(-4,8,-7),


        new Vector3(-3,8,-7),
        new Vector3(-2,8,-7),
        new Vector3(-1,8,-7),
        new Vector3(-1,8,-6),
        new Vector3(-1,8,-5),


        new Vector3(-7,8,-3),
        new Vector3(-7,9,-3),
        new Vector3(-7,10,-3),
        new Vector3(-7,11,-3),
        new Vector3(-7,12,-3),
        new Vector3(-7,13,-3),
        new Vector3(-7,14,-3),
        new Vector3(-7,14,-2),
        new Vector3(-7,14,-1),
        new Vector3(-7,14,0),
        new Vector3(-7,14,1),

        new Vector3(-7,14,-4),
        new Vector3(-7,14,-5),
        new Vector3(-7,14,-6),
        new Vector3(-7,14,-7),
        new Vector3(-7,14,-8),
        new Vector3(-7,14,-9),
        new Vector3(-7,14,-10),
   
        new Vector3(-13,22,-5),
    };
	
	Vector3[] slopePos = new Vector3[]{
        new Vector3(-15,22,-7),
        new Vector3(-7,14,-11),

    };
	
	Quaternion[] slopeRot = new Quaternion[]{
		Quaternion.Euler(0,270,90),
        Quaternion.Euler(0,270,90),

    };
	
	RotatingObject[] rotObj = new RotatingObject[]{
        new RotatingObject("C-78-4", new Vector3(-7,8,-7), new Vector3(0,1,0), true),
        new RotatingObject("C-78-5", new Vector3(-7,8,-7), new Vector3(0,1,0), true),
		new RotatingObject("C-78-6", new Vector3(-7,8,-7), new Vector3(0,1,0), true),
		new RotatingObject("C-78-7", new Vector3(-7,8,-7), new Vector3(0,1,0), true),
        new RotatingObject("C-68-7", new Vector3(-7,8,-7), new Vector3(0,1,0), true),
        new RotatingObject("C-58-7", new Vector3(-7,8,-7), new Vector3(0,1,0), true),
        new RotatingObject("C-48-7", new Vector3(-7,8,-7), new Vector3(0,1,0), true),

        new RotatingObject("C-714-4", new Vector3(-7,14,-7), new Vector3(0,1,0), true),
        new RotatingObject("C-714-5", new Vector3(-7,14,-7), new Vector3(0,1,0), true),
        new RotatingObject("C-714-6", new Vector3(-7,14,-7), new Vector3(0,1,0), true),
        new RotatingObject("C-714-7", new Vector3(-7,14,-7), new Vector3(0,1,0), true),
        new RotatingObject("C-714-8", new Vector3(-7,14,-7), new Vector3(0,1,0), true),
        new RotatingObject("C-714-9", new Vector3(-7,14,-7), new Vector3(0,1,0), true),
        new RotatingObject("C-714-10", new Vector3(-7,14,-7), new Vector3(0,1,0), true),

        //new RotatingObject("S-714-11", new Vector3(-7,14,-7), new Vector3(0,1,0), true),

    };

    Vector3 playerStart = new Vector3(-15, 8, -13);


    public Vector3[] CubePos{ get{ return cubePos; } }
	public Vector3[] SlopePos{ get{ return slopePos; } }
	public Quaternion[] SlopeRot{ get{ return slopeRot; } }
	public RotatingObject[] RotObj{ get{ return rotObj; } }
	public Vector3 PlayerStart{ get{ return playerStart; } }
    public int Number { get { return 5; } }
	
}
