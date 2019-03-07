using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundOptionUI : MonoBehaviour
{
    public Slider bgmSlider;
    public Slider sfxSlider;

    public Toggle bgmToggle;
    public Toggle sfxToggle;

    private void OnEnable()
    {
        bgmSlider.value = SoundManager.Instance.BgmVolume;
        sfxSlider.value = SoundManager.Instance.SfxVolume;

        bgmToggle.isOn = SoundManager.Instance.BgmMute;
        sfxToggle.isOn = SoundManager.Instance.SfxMute;
    }

    public void SetBgmVolume(float value)
    {
        SoundManager.Instance.BgmVolume = value;
    }

    public void SetSfxVolume(float value)
    {
        SoundManager.Instance.SfxVolume = value;
    }

    public void SetBgmMute(bool flag)
    {
        SoundManager.Instance.BgmMute = flag;
    }

    public void SetSfxMute(bool flag)
    {
        SoundManager.Instance.SfxMute = flag;
    }
}
