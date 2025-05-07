using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum  UIState
{
    None,
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
    public abstract void Init();

    // TODO : UI 종류 반환 로직
    public abstract UIState GetUIState();

    public void ActiveChange(UIState state)
    {
        this.gameObject.SetActive(GetUIState() == state);
    }
}
