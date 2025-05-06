using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DiceSumUI : ScoreUI
{
    [SerializeField] private TextMeshProUGUI curNumTxt;
    [SerializeField] private TextMeshProUGUI totNumTxt;

    public void UpdateSumText(int sum)
    {
        // TODO : 숫자 합 UI 반영
    }

    public void UpdateTotalText(int total)
    {
        // TODO : 목표 총 합 UI 반영
    }
}
