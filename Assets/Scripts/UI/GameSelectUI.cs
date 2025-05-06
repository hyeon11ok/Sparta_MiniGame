using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum GameSlot
{
    Prev,
    Select,
    Next
}

public class GameSelectUI : BaseUI
{
    [SerializeField] private Transform[] gameSlot;
    [SerializeField] private GameObject[] gameButton;
    private SceneName selectedScene;

    private void SetGameSlot()
    {
        // TODO : 게임 슬롯 설정
    }

    public void NextGame()
    {
        // TODO : selectedScene 1 증가
    }

    public void PrevGame()
    {
        // TODO : selectedScene 1 감소
    }

    public void SelectGame()
    {
        // TODO : 선택한 게임 씬으로 전환
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
