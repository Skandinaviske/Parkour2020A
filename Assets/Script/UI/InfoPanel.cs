using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoPanel : PanelBase
{
    Button CloseBtn;
    //Lifecycle
    public override void Init(params object[] args) 
    {
        base.Init(args);
        skinPath = "IntrPanel";
        layer = PanelLayer.Panel;
    }

    public override void OnShowing() 
    {
        base.OnShowing();
        Transform skinTrans = skin.transform;
        CloseBtn = skinTrans.Find("CloseBtn").GetComponent<Button>();
        CloseBtn.onClick.AddListener(OnCloseClick);
    }

    public void OnCloseClick()
    {
        Close();
    }
}
