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
        // TODO : 옵션 저장 로직
        Debug.Log("OptionUI Accept");
    }

    public override UIState GetUIState()
    {
        return UIState.OptionUI;
    }

    public override void Init(UIManager manager)
    {
        // TODO : 오디오 설정 동기화
    }
}
