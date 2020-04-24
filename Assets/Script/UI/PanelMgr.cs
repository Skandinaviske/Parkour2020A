using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class PanelMgr : MonoBehaviour
{

    //单例
    public static PanelMgr instance;
    //Panel
    GameObject canvas;
    public Dictionary<string, PanelBase> dict;
    //hierecy
    Dictionary<PanelLayer, Transform> layerDict;
    public AudioSource audioSource;
    float time = 0;
    public GameObject button;

    //Strat
    public void Awake()
    {
        instance = this;
        InitLayer();
        dict = new Dictionary<string, PanelBase>();
    }
    public void Start() 
    {
        button.SetActive(false);
    }
    public void Update() 
    {
        //time += Time.deltaTime;
        //if (time > 62)
        //{
        //    audioSource.Stop();

        //}
    }

    public void InitLayer() 
    {
        //Canvas
        canvas = GameObject.Find("Canvas");
        if (canvas == null) 
            Debug.LogError("PanelMgr.initLayer Error！canvas值是空的");
            //Every hierecy;
            layerDict = new Dictionary<PanelLayer, Transform>();

            foreach (PanelLayer player in Enum.GetValues(typeof(PanelLayer)))
            {
                string name = player.ToString();
                Transform transform = canvas.transform.Find(name);
                layerDict.Add(player, transform);
            }
    }

    //Open panel
    public void OpenPanel<T>(string skinPath, params object[] args) where T : PanelBase 
    {
        //Already Open;
        string name = typeof(T).ToString();
        if (dict.ContainsKey(name))
            return;
        PanelBase panel = canvas.AddComponent<T>();
        panel.Init(args);
        dict.Add(name, panel);
        //Load skin
        skinPath = (skinPath != "" ? skinPath : panel.skinPath);
        GameObject skin = Resources.Load<GameObject>(skinPath);
        if (skin == null)
            Debug.LogError("PanelMgr.OpenPanel Error! Skin is null, skin path = " + skinPath);
        panel.skin = Instantiate(skin);
        //坐标
        Transform skinTrans = panel.skin.transform;
        PanelLayer layer = panel.layer;
        Transform parent = layerDict[layer];
        skinTrans.SetParent(parent, false);
        //The life cycle of panel
        panel.OnShowing();
        //Animation
        panel.OnShowed();
    }


    //Close panel
    public void ClosePanel(string name) 
    {
        PanelBase panel = (PanelBase)dict[name];
        if (panel == null)
            return;
        panel.OnClosing();
        dict.Remove(name);
        panel.OnClosed();
        Destroy(panel.skin);
        Component.Destroy(panel);
    }

    /**
    public void InfoPanelBtnClick() 
    {
        InfoPanel.SetActive(true);    
    }

    public void InfoPanelClose() 
    {
        InfoPanel.SetActive(false);    
    }
     **/

    //public void Stop() 
    //{
    //    //audioSource.Stop();
    //    button.SetActive(false);
    //}
}

    public enum PanelLayer
    {
        //
        Panel,
        //
        Tips
    }


