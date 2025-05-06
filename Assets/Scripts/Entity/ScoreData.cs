using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreData
{
    private List<int> scoreList = new List<int>();
    public int HightScore { get; private set; }

    public void AddScore(int score)
    {
        // TODO : 점수 추가, 점수 리스트 정렬
        Debug.Log("Add Score");
        SortScoreList();
    }

    private void SortScoreList()
    {
        // TODO : 점수 정렬, 내림차순, 최고 점수 저장
        Debug.Log("Score Sort");
    }
}
