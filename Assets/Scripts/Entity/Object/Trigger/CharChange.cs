using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharChange : MonoBehaviour, ITrigger
{
    [SerializeField] private Animator animator;
    [SerializeField] private Sprite sprite;

    public void TriggerEnterEvent(GameObject gameObject)
    {
        throw new System.NotImplementedException();
        // TODO : �÷��̾��� �ִϸ�����, �̹��� ����
    }
}
