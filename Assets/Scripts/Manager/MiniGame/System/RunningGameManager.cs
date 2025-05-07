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

    private const int poolCnt = 20;
    public List<Bomb> BombPool {  get; private set; } = new List<Bomb>();
    public List<Coin> CoinPool { get; private set; } = new List<Coin>();

    private void Update()
    {
        MoveBackground();
    }

    public override void Initialize()
    {
        for(int i = 0; i < poolCnt; i++)
        {
            CreateObstaclePool<Bomb>(originBomb, BombPool);
            CreateObstaclePool<Coin>(originCoin, CoinPool);
        }
    }

    public void MoveBackground()
    {
        Vector2 offset = bgRenderer.material.mainTextureOffset;
        offset.x += speedOfBg * Time.deltaTime;
        bgRenderer.material.mainTextureOffset = offset;
    }

    public void CreateObstaclePool<T>(GameObject model, List<T> pool)
    {
        GameObject obstacleTmp = Instantiate(model, transform);
        obstacleTmp.SetActive(false);
        pool.Add(model.GetComponent<T>());
    }


}
