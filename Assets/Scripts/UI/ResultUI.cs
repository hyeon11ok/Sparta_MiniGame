using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResultUI:BaseUI
{
    [SerializeField] private MiniGameManager gameManager;
    [SerializeField] private TextMeshProUGUI curScoreTxt;
    [SerializeField] private TextMeshProUGUI bestScoreTxt;

    public void UpdateScoreText()
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
