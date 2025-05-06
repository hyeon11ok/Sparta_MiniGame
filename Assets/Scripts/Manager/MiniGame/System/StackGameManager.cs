using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackGameManager:MiniGameManager
{
    private BaseMiniGameUIManager uiManager;

    [SerializeField] private GameObject originBlock;
    private Block curBlock;
    [SerializeField] private Color prevColor;
    [SerializeField] private Color curColor;

    public override void Initialize()
    {
        throw new System.NotImplementedException();
    }

    public void SpawnBlock()
    {
        // TODO : 블록 생성 로직
        // 블록의 색상은 랜덤으로 설정
        // 블록의 위치는 이전 블록의 위치에 따라 결정
        // 블록의 크기는 이전 블록의 크기에 따라 결정
    }

    public void SpawnRubble(int width)
    {
        // TODO : 블록이 떨어졌을 때 파편 생성 로직
        // 파편의 색상은 이전 블록의 색상과 같음
    }

    public bool PlaceBlock()
    {
        // TODO : 블록을 쌓는 로직
        // 블록의 위치와 크기를 조정
        // 블록이 쌓였는지 확인
        return true; // 예시로 true 반환
    }

    public void ColorChange()
    {
        // TODO : 블록 색상 변경 로직
        // 블록의 색상을 랜덤으로 변경
        // 이전 블록의 색상과 다르게 설정
    }
}
