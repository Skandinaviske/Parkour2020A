using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginPanel : PanelBase
{
    // Start is called before the first frame update
    Button startBtn;
    Button infoBtn;

    public override void Init(params object[] args) 
    {
        base.Init(args);
        skinPath = "LogginPanel";
        layer = PanelLayer.Panel;
    }

    public override void OnShowing() 
    {
        base.OnShowing();
        Transform skinTrans = skin.transform;
        startBtn = skinTrans.Find("StartGame").GetComponent<Button>();
        infoBtn = skinTrans.Find("IntrGame").GetComponent<Button>();
        startBtn.onClick.AddListener(OnStartClick);
        infoBtn.onClick.AddListener(OnInfoClick);
    }

    public void OnStartClick() 
    { 
        //Start game
        SceneManager.LoadScene(1);
    }

    public void OnInfoClick() 
    {
        PanelMgr.instance.OpenPanel<InfoPanel>("");
    
    }
}
