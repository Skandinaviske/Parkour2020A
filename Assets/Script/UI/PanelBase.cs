using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelBase : MonoBehaviour
{
    //Skin root
    public string skinPath;
    //Skin
    public GameObject skin;
    //level
    public PanelLayer layer;
    //panel parameter
    public object[] args;
    //life cycle
    //init
    public virtual void Init(params object[] args) 
    {
        this.args = args;
    }
    //Before open panel
    public virtual void OnShowing() 
    { }
    //After open panel
    public virtual void OnShowed() 
    { }
    //Frame update
    public virtual void Update() 
    { }
    //Before close
    public virtual void OnClosing() 
    { }
    public virtual void OnClosed()
    { }
    //Multiple
    protected virtual void Close() 
    {
        string name = this.GetType().ToString();
        PanelMgr.instance.ClosePanel(name);
    }
}
