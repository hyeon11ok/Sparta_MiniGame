using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionUI : BaseUI
{
    [SerializeField] private Slider masterVolume;
    [SerializeField] private Slider bgmVolume;
    [SerializeField] private Slider sfxVolume;

    private void Awake()
    {
        // uiManager = FindObjectOfType<UIManager>();
    }

    private void OnEnable()
    {
        Init();
    }

    public void Close()
    {
        AudioManager.Instance.ChangeMasterVolume(AudioManager.Instance.m_value);
        AudioManager.Instance.ChangeBGMVolume(AudioManager.Instance.b_value);
        AudioManager.Instance.ChangeSFXVolume(AudioManager.Instance.s_value);
    }

    public override UIState GetUIState()
    {
        return UIState.OptionUI;
    }

    public override void Init()
    {
        AudioManager.Instance.LoadVolume();
        masterVolume.value = AudioManager.Instance.m_value;
        bgmVolume.value = AudioManager.Instance.b_value;
        sfxVolume.value = AudioManager.Instance.s_value;
    }
}
