using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUI : MonoBehaviour
{

    MapMaker stage;

    // Start is called before the first frame update
    void Start()
    {
        stage = GameObject.Find("MapMaker").GetComponent<MapMaker>();
    }

    private void OnGUI()
    {
        GUI.Box(new Rect(10, 50, 100, 220), "Select");
        if(GUI.Button(new Rect(20, 80, 80, 20), "1"))
        {
            stage.Load(1);
        }
        if (GUI.Button(new Rect(20, 110, 80, 20), "2"))
        {
            stage.Load(2);
        }
        if (GUI.Button(new Rect(20, 140, 80, 20), "3"))
        {
            stage.Load(3);
        }
        if (GUI.Button(new Rect(20, 170, 80, 20), "4"))
        {
            stage.Load(4);
        }
        if (GUI.Button(new Rect(20, 200, 80, 20), "5"))
        {
            stage.Load(5);
        }
        if (GUI.Button(new Rect(20, 230, 80, 20), "Exit"))
        { 
           Application.Quit();
        }
    }
}
