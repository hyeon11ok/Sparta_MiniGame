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
        // TODO : 플레이어의 애니메이터, 이미지 변경
    }
}
