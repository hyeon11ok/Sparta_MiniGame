using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyUIManager : UIManager
{
    private GameSelectUI gameSelectUI;

    public void ShowSelectUI()
    {
        ChangeState(UIState.GameSelectUI);
    }

    public void SelectGameScene(SceneName name)
    {
        // gameManager.ChangeScene(name);
    }

    public override void ChangeState(UIState state)
    {
        throw new System.NotImplementedException();
        // TODO : UIState ���� �� Ȱ��ȭ
    }

    public override void Init()
    {
        throw new System.NotImplementedException();
    }
}
