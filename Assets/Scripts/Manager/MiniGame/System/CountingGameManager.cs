using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountingGameManager:MiniGameManager
{
    private BaseMiniGameUIManager uiManager;

    [SerializeField] private int randNumMin;
    [SerializeField] private int randNumMax;
    [SerializeField] private Dice[] dices;
    private int targetNum;
    private int currentNum;
    private int addCount; // ���� ���� ����, �ֻ��� 3�� �� 2���� ���ϸ� �ֻ��� �ʱ�ȭ

    public override void Initialize()
    {
        // TODO : �̴ϰ��� �ʱ�ȭ
        SetTargetNumber();
    }

    private void SetTargetNumber()
    {
        // TODO : ���� ���� ���� ����
        Debug.Log("Set Target Number");
    }

    public void AddNumber(int num)
    {
        // TODO : ���� ���ϱ� ����
        Debug.Log("Add Number");
        // TODO : Ŭ���� üũ
        Debug.Log("Check Clear");
    }
}
