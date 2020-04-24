using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMaker : MonoBehaviour
{

    //public static MapMaker _instance;


    //IMapData currentMap;
    Vector3[] slopeVertices = new Vector3[]
    {
        new Vector3(-0.5f, -0.5f, -0.5f),
        new Vector3(0.5f, -0.5f, -0.5f),
        new Vector3(0.5f, -0.5f, 0.5f),
        new Vector3(-0.5f, -0.5f, 0.5f),

        new Vector3(-0.5f, -0.5f, -0.5f),
        new Vector3(0.5f, -0.5f, -0.5f),
        new Vector3(0.5f, 0.5f, -0.5f),

        new Vector3(0.5f, -0.5f, 0.5f),
        new Vector3(-0.5f, -0.5f, 0.5f),
        new Vector3(0.5f, 0.5f, 0.5f),

        new Vector3(-0.5f, -0.5f, -0.5f),
        new Vector3(0.5f, 0.5f, -0.5f),
        new Vector3(0.5f, 0.5f, 0.5f),
        new Vector3(-0.5f, -0.5f, 0.5f),

        new Vector3(0.5f, -0.5f, -0.5f),
        new Vector3(0.5f, -0.5f, 0.5f),
        new Vector3(0.5f, 0.5f, 0.5f),
        new Vector3(0.5f, 0.5f, -0.5f),
    };

    int[] slopeTriangles = new int[]
    {
        0, 1, 2,
        0, 2, 3,
        4, 6, 5,
        8, 7, 9,
        10, 12, 11,
        10, 13, 12,
        14, 17, 15,
        15, 17, 16,
    };

    GameObject makeSlope()
    {
        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        obj.name = "Slope";
        Mesh mesh = obj.GetComponent<MeshFilter>().mesh;
        mesh.Clear();
        mesh.vertices = slopeVertices;
        mesh.triangles = slopeTriangles;
        mesh.RecalculateNormals();
        return obj;
    }

    //private void Awake()
    //{
    //    _instance = this;
    //}
    // Start is called before the first frame update
    void Start()
    {
        //IMapData mp1 = new Map01();
        //currentMap = mp1;
        MakeMap(new Map01());

    }

    void MakeMap(IMapData mapData)
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Floor");
        foreach (GameObject obj in objs)
        {
            GameObject.DestroyImmediate(obj);
        }
        //foreach (Vector3 pos in mapData.CubePos)
        for (int i = 0; i < mapData.CubePos.Length; i++)
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.GetComponent<Renderer>().material.color = Color.red;
            if (i == mapData.CubePos.Length-1)
                cube.GetComponent<Renderer>().material.color = Color.yellow;
            cube.tag = "Floor";
            cube.name = "C" + mapData.CubePos[i].x + mapData.CubePos[i].y + mapData.CubePos[i].z;
            cube.transform.position = mapData.CubePos[i];
 
        }
        for (int i = 0; i < mapData.SlopePos.Length; i++)
        {
            GameObject slope = makeSlope();
            slope.GetComponent<Renderer>().material.color = Color.red;
            Vector3 pos = mapData.SlopePos[i];
            slope.tag = "Floor";
            slope.name = "S" + pos.x + pos.y + pos.z;
            slope.transform.position = pos;
            slope.transform.rotation = mapData.SlopeRot[i];
        }
        foreach (RotatingObject data in mapData.RotObj)
        {
            GameObject obj = GameObject.Find(data.name);
            if (obj == null) continue;
            Rotating script = obj.AddComponent<Rotating>() as Rotating;
            script.point = data.point;
            script.axis = data.axis;
            script.PlayerRot = data.playerRot;
        }
        {
            GameObject player = GameObject.Find("character284");
            player.transform.position = new Vector3(mapData.PlayerStart.x, mapData.PlayerStart.y + 1, mapData.PlayerStart.z);
            player.GetComponent<CharacterMove>().Init();
            player.GetComponent<CharacterMove>().getCurrent(mapData.Number);
        }
    }

    public void Load (int stage_id)
    {
        switch (stage_id)
        {
            case 1:
                //IMapData mp01 = new Map01();
                //currentMap = mp01;
                MakeMap(new Map01());
                break;
            case 2:
                MakeMap(new Map02());
                break;
            case 3:
                MakeMap(new Map03());
                break;
            case 4:
                MakeMap(new Map04());
                break;
            case 5:
                MakeMap(new Map05());
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
