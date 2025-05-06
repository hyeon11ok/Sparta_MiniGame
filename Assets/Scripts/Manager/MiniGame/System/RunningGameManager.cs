using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningGameManager:MiniGameManager
{
    private BaseMiniGameUIManager uiManager;

    [Header("Background")]
    [SerializeField] private SpriteRenderer bgRenderer;
    [SerializeField] private float speedOfBg;

    [Header("Obstacle")]
    [SerializeField] private GameObject originBomb;
    [SerializeField] private GameObject originCoin;

    public List<Bomb> BombPool {  get; private set; } = new List<Bomb>();
    public List<Coin> CoinPool { get; private set; } = new List<Coin>();

    public override void Initialize()
    {
        throw new System.NotImplementedException();
    }

    public void MoveBackground()
    {
        // TODO : 배경 이동 로직(머터리얼 속성으로 이동)
    }

    public void CreateObstaclePool()
    {
        // TODO : 장애물 풀 생성 로직
    }
}
