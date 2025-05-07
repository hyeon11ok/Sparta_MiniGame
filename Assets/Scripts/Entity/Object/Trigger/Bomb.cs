using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : Obstacle
{
    [SerializeField] private float speedMin;
    [SerializeField] private float speedMax;

    private void OnEnable()
    {
        SetRandomSpeed();
    }

    private void Update()
    {
        MoveObstacle();
    }

    public void SetRandomSpeed()
    {
        speed = Random.Range(speedMin, speedMax);
    }

    public override void TriggerEnterEvent(GameObject gameObject)
    {
        base.TriggerEnterEvent(gameObject);
        // TODO : 게임 오버
    }
}
