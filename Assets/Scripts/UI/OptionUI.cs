using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionUI : BaseUI
{
    [SerializeField] private Slider masterVolume;
    [SerializeField] private Slider bgmVolume;
    [SerializeField] private Slider sfxVolume;

    public void Accept()
    {
        // TODO : �ɼ� ���� ����
        Debug.Log("OptionUI Accept");
    }

    public override UIState GetUIState()
    {
        return UIState.OptionUI;
    }

    public override void Init(UIManager manager)
    {
        // TODO : ����� ���� ����ȭ
    }
}
