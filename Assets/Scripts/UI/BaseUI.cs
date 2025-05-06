using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum  UIState
{
    GameSelectUI,
    ScoreUI,
    OptionUI
}

public abstract class BaseUI : MonoBehaviour
{
    protected UIManager uiManager;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        
    }

    // TODO : UI 초기화 로직
    public abstract void Init(UIManager manager);

    // TODO : UI 종류 반환 로직
    public abstract UIState GetUIState();

    public void SetActive(UIState state)
    {
        // TODO : UI 활성화 로직
    }
}
