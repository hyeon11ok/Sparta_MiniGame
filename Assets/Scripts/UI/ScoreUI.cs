using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUI:BaseUI
{
    [SerializeField] private TextMeshProUGUI scoreTxt;

    public void UpdateScoreText(int score)
    {
        // TODO : ���� UI �ݿ�
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
