using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreData
{
    private List<int> scoreList = new List<int>();
    public int HightScore { get; private set; }

    public void AddScore(int score)
    {
        // TODO : ���� �߰�, ���� ����Ʈ ����
        Debug.Log("Add Score");
        SortScoreList();
    }

    private void SortScoreList()
    {
        // TODO : ���� ����, ��������, �ְ� ���� ����
        Debug.Log("Score Sort");
    }
}
