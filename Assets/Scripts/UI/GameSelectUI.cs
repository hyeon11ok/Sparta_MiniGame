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
        // TODO : ���� ���� ����
    }

    public void NextGame()
    {
        // TODO : selectedScene 1 ����
    }

    public void PrevGame()
    {
        // TODO : selectedScene 1 ����
    }

    public void SelectGame()
    {
        // TODO : ������ ���� ������ ��ȯ
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
