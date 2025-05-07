using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyUIManager : UIManager
{
    private GameSelectUI gameSelectUI;

    private void Start()
    {
        Init();
    }

    public void ShowSelectUI()
    {
        GameManager.Instance.PauseGame();
        ChangeState(UIState.GameSelectUI);
    }

    public void CloseUI()
    {
        ChangeState(UIState.None);
    }

    public override void ChangeState(UIState state)
    {
        curState = state;
        gameSelectUI.ActiveChange(curState);
    }

    public override void Init()
    {
        gameSelectUI = GetComponentInChildren<GameSelectUI>(true);
    }
}
