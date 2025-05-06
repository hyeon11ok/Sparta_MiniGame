using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MiniGameManager : MonoBehaviour
{
    public ScoreData GameScore { get; private set; } = new ScoreData();
    public int CurScore { get; private set; }

    protected virtual void Start()
    {
        Initialize();
    }

    // TODO : 미니게임 초기화
    public abstract void Initialize();

    public void GameOver()
    {
        // TODO : 게임 오버 처리
        Debug.Log("Game Over");
        // TODO : 점수 기록
        Debug.Log($"Add Score");
        // TODO : 점수 저장
        DataManager.Instance.SaveScore(GameManager.Instance.CurrentScene, GameScore);
    }

    public void IncreaseScore()
    {
        // TODO : 점수 증가
        Debug.Log("Increase Score");
    }
}
