using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : ChangeUI<Graphic,Color>
{
    public override void Change(bool flag)
    {
        target.color = flag ? onValue : offValue;
    }
}
