using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour, ITrigger
{
    [SerializeField] protected float speed;

    public virtual void TriggerEnterEvent(GameObject gameObject)
    {
        throw new System.NotImplementedException();
    }

    protected void MoveObstacle()
    {
        // TODO : 장애물 이동
    }
}
