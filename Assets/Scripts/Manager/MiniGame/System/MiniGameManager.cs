using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MiniGameManager : MonoBehaviour
{
    public int CurScore { get; private set; }

    protected virtual void Start()
    {
        Initialize();
    }

    // TODO : �̴ϰ��� �ʱ�ȭ
    public abstract void Initialize();

    public void GameOver()
    {
        // TODO : ���� ���� ó��
        Debug.Log("Game Over");
        // TODO : ���� ���
        Debug.Log($"Add Score");
        // TODO : ���� ����
    }

    public void IncreaseScore()
    {
        // TODO : ���� ����
        Debug.Log("Increase Score");
    }
}
