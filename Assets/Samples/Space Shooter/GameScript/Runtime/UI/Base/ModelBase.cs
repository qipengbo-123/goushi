using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �������� �������� ���ݻ�ȡ ��������
/// </summary>
public class ModelBase
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
