using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ��View��Model���м������ view����ִ��ʲô���� �Ҳ�����������model�����
/// </summary>
public class ControlBase
{
    public UIWindow uiBase;
    public virtual void Init(UIWindow uiBase)
    {
        this.uiBase = uiBase;
    }

    public virtual void OnEnable()
    {

    }

    public virtual void OnDestory()
    {

    }
}
