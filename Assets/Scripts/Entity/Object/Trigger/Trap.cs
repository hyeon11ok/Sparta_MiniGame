using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour, ITrigger
{
    [SerializeField] private Vector2 startPos;

    public void TriggerEnterEvent(GameObject gameObject)
    {
        throw new System.NotImplementedException();
        // TODO : �÷��̾� ��ġ �̵�
    }
}
