using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameSelectUI : BaseUI
{
    [SerializeField] private Transform[] gameSlot;
    [SerializeField] private Button closeBtn;
    private int curIdx = 0;

    private void OnEnable()
    {
        Init();
    }

    private void SetGameSlot()
    {
        int i = -1;
        foreach(Transform t in gameSlot)
        {
            int idx = curIdx + i;
            if(idx < 0)
                idx = DataManager.Instance.MiniGameDatas.Count - 1;
            else if (idx >= DataManager.Instance.MiniGameDatas.Count)
                idx = 0;

            t.GetChild(0).GetComponent<TextMeshProUGUI>().text = DataManager.Instance.MiniGameDatas[idx].GameName;
            t.GetChild(2).GetComponent<TextMeshProUGUI>().text = DataManager.Instance.MiniGameDatas[idx].ScoreRank.Replace("/", "\n");
            i++;
        }
    }

    public void NextGame()
    {
        curIdx++;
        if(curIdx >= DataManager.Instance.MiniGameDatas.Count)
            curIdx = 0;

        SetGameSlot();
    }

    public void PrevGame()
    {
        curIdx--;
        if(curIdx < 0)
            curIdx = DataManager.Instance.MiniGameDatas.Count - 1;

        SetGameSlot();
    }

    public void SelectGame()
    {
        GameManager.Instance.ChangeScene(DataManager.Instance.MiniGameDatas[curIdx].sceneName);
    }

    public override UIState GetUIState()
    {
        return UIState.GameSelectUI;
    }

    public override void Init()
    {
        SetGameSlot();
    }

    public void ClosedUI()
    {
        GameManager.Instance.ResumeGame();
    }
}
