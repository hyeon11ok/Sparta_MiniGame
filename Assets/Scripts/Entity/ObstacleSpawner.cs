using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    private RunningGameManager gameManager;

    [SerializeField] private float spawnTimeMin;
    [SerializeField] private float spawnTimeMax;
    private float spawnTime;

    [SerializeField] private int yPosMin;
    [SerializeField] private int yPosMax;
    private int yPos;

    [SerializeField] private float coinSpawnPer;

    private void Start()
    {
        gameManager = FindObjectOfType<RunningGameManager>();
    }

    private void Update()
    {
        
    }

    public void SpawnObstacle()
    {

    }
}
