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
    private int addCount; // 더한 숫자 개수, 주사위 3개 중 2개를 더하면 주사위 초기화

    public override void Initialize()
    {
        // TODO : 미니게임 초기화
        SetTargetNumber();
    }

    private void SetTargetNumber()
    {
        // TODO : 랜덤 숫자 생성 로직
        Debug.Log("Set Target Number");
    }

    public void AddNumber(int num)
    {
        // TODO : 숫자 더하기 로직
        Debug.Log("Add Number");
        // TODO : 클리어 체크
        Debug.Log("Check Clear");
    }
}
