using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUI:BaseUI
{
    [SerializeField] private TextMeshProUGUI scoreTxt;

    public void UpdateScoreText(int score)
    {
        // TODO : 점수 UI 반영
    }

    public override UIState GetUIState()
    {
        throw new System.NotImplementedException();
    }

    public override void Init(UIManager manager)
    {
        throw new System.NotImplementedException();
    }
}
