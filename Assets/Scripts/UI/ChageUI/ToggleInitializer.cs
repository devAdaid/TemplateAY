using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[System.Serializable]
public class ToggleEvent : UnityEvent<bool> { }

[RequireComponent(typeof(Toggle))]
public class ToggleInitializer : MonoBehaviour
{
    public Toggle toggle;
    public ToggleEvent events;

    private void Reset()
    {
        if (toggle == null)
            toggle = GetComponent<Toggle>();
    }

    private void Start()
    {
        if(events.GetPersistentEventCount() > 0)
        {
            events.Invoke(toggle.isOn);
        }
        else
        {
            toggle.onValueChanged.Invoke(toggle.isOn);
        }
    }
}
