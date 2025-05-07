using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RunningPlayerController : BasePlayerController
{
    [SerializeField] private float flapForce = 6f;
    [SerializeField] private float forwardSpeed = 3f;
    [SerializeField] private bool isDead = false;
    [SerializeField] private float deathCooldown = 0f;

    bool isFlap = false;

    public override void Move()
    {
        if(isDead) return;

        Vector3 velocity = _rigidbody.velocity;
        velocity.x = forwardSpeed;

        if(isFlap)
        {
            velocity.y += flapForce;
            isFlap = false;
        }

        _rigidbody.velocity = velocity;
    }

    public override void Rotate()
    {
        float angle = Mathf.Clamp((_rigidbody.velocity.y * 10f), -90, 90);
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    public void OnJump(InputValue inputValue)
    {
        if(inputValue.isPressed)
        {
            isFlap = true;
        }
    }
}
