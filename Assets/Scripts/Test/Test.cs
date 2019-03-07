using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Test : MonoBehaviour
{
    public UnityEvent events;

    private void Start()
    {
        events.Invoke();
    }

    public void SoundTest()
    {
        SoundManager.Instance.Echo();
    }
}
