using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeFadeColor : ChangeUI<Graphic, Color>
{
    public float fadeTime = 0.2f;

    private Color fromColor = Color.white;
    private Color toColor = Color.white;
    private bool bFading = false;

    public override void Change(bool flag)
    {
        StartCoroutine(Fade(flag));
    }

    public override void StopChange()
    {
        if (!bFading)
            return;
        StopAllCoroutines();
        target.color = toColor;
        bFading = false;
    }

    public override void ImmediateChange(bool flag)
    {
        toColor = flag ? onValue : offValue;
        target.color = toColor;
    }

    IEnumerator Fade(bool flag)
    {
        bFading = true;

        float t = 0f;
        float step = Time.fixedDeltaTime / fadeTime;
        fromColor = flag ? offValue : onValue;
        toColor = flag ? onValue : offValue;

        while (t < 1f)
        {
            target.color = Color.Lerp(fromColor, toColor, t);
            yield return new WaitForFixedUpdate();
            t += step;
        }

        target.color = toColor;
        bFading = false;
    }
}
