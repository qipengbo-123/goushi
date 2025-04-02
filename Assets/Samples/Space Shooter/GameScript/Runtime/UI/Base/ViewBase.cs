using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

/// <summary>
/// ִ���û�����֮����߼� ����� ����¼� ִ�е���Control������߼�
/// </summary>
public class ViewBase
{
    public UIWindow uiBase;
    public Dictionary<Button, UnityAction> btnListenerDic = new Dictionary<Button, UnityAction>();
    public virtual void Init(UIWindow uiBase)
    {
        this.uiBase = uiBase;
    }

    public void AddButtonListener(Button btn,UnityAction action)
    {
        btn.onClick.AddListener(action);
        btnListenerDic.Add(btn, action);
    }

    public virtual void OnEnable()
    {

    }

    public virtual void OnDestory()
    {
        RemoveAllBtnListener();
    }

    private void RemoveAllBtnListener()
    {
        foreach(var item in btnListenerDic)
        {
            item.Key.onClick.RemoveListener(item.Value);
        }
    }

    public virtual void Update()
    {

    }
}
