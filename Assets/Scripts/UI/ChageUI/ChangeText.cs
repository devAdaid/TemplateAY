using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : ChangeUI<Text,string>
{
    public override void Change(bool flag)
    {
        target.text = flag ? onValue : offValue;
    }
}
