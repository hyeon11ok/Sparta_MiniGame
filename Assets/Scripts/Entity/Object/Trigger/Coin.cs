using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Obstacle
{
    [SerializeField] private int bonusScoreMin;
    [SerializeField] private int bonusScoreMax;
    private int bonusScore;

    private void OnEnable()
    {
        SetRandomScore();
    }

    private void Update()
    {
        MoveObstacle();
    }

    public void SetRandomScore()
    {
        bonusScore = Random.Range(bonusScoreMin, bonusScoreMax);
    }

    public override void TriggerEnterEvent(GameObject gameObject)
    {
        base.TriggerEnterEvent(gameObject);
        // TODO : Á¡¼ö È¹µæ
    }
}
