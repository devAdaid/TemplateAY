using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleChangeUI : MonoBehaviour
{
    private IChangeUI[] _changeUIs;

    protected void Awake()
    {
        _changeUIs = GetComponentsInChildren<IChangeUI>();
    }

    public virtual void Change(bool flag)
    {
        foreach (IChangeUI ui in _changeUIs)
        {
            ui.Change(flag);
        }
    }

    public virtual void ImmediateChange(bool flag)
    {
        foreach (IChangeUI ui in _changeUIs)
        {
            ui.ImmediateChange(flag);
        }
    }

    public virtual void StopChange(bool flag)
    {
        foreach (IChangeUI ui in _changeUIs)
        {
            ui.StopChange();
        }
    }
}
