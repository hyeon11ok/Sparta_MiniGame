using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMiniGameUIManager : UIManager
{
    private ScoreUI scoreUI;
    private ResultUI resultUI;

    public void SetGameOver()
    {
        // resultUI.UpdateScoreText();
    }

    public override void ChangeState(UIState state)
    {
        throw new System.NotImplementedException();
    }

    public override void Init()
    {
        throw new System.NotImplementedException();
    }
}
