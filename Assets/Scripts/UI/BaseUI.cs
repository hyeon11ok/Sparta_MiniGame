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

    // TODO : UI �ʱ�ȭ ����
    public abstract void Init(UIManager manager);

    // TODO : UI ���� ��ȯ ����
    public abstract UIState GetUIState();

    public void SetActive(UIState state)
    {
        // TODO : UI Ȱ��ȭ ����
    }
}
