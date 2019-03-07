using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IChangeUI
{
    void Change(bool flag);
    void ImmediateChange(bool flag);
    void StopChange();
}

public abstract class ChangeUI<T1,T2> : MonoBehaviour, IChangeUI
{
    public T1 target;
    public T2 onValue;
    public T2 offValue;


    protected void Reset()
    {
        if (target == null)
        {
            target = GetComponent<T1>();
        }
    }

    public abstract void Change(bool flag);
    public virtual void ImmediateChange(bool flag) { }
    public virtual void StopChange() { }
}