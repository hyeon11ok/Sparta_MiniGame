using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TopDownPlayerController : BasePlayerController
{
    [SerializeField] private float speed;
    private Vector2 moveDir;
    private Vector2 lookDir;

    public override void Move()
    {
        throw new System.NotImplementedException();
    }

    public override void Rotate()
    {
        throw new System.NotImplementedException();
    }

    public void OnMove(InputValue inputValue)
    {
        // TODO : ĳ���� �̵�
    }

    public void OnLook(InputValue inputValue)
    {
        // TODO : ���콺 ���⿡ ���� ĳ���� �ø�
    }
}
