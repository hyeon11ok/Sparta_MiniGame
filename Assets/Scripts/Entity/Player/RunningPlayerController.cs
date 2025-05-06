using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RunningPlayerController : BasePlayerController
{
    [SerializeField] private float jumpForce;

    public override void Move()
    {
        throw new System.NotImplementedException();
    }

    public override void Rotate()
    {
        throw new System.NotImplementedException();
    }

    public void OnJump(InputValue inputValue)
    {
        // TODO : มกวม
    }
}
