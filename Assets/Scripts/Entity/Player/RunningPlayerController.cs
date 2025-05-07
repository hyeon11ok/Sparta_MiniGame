using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class RunningPlayerController : BasePlayerController
{
    [SerializeField] private float fowardSpeed;
    [SerializeField] private float jumpForce;
    private bool isJump = false;

    public override void Move()
    {
        if(isJump && _rigidbody.velocity.y < 0)
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.5f, 1 << 6);
            if(hit.collider != null)
            {
                isJump = false;
            }
        }
    }

    public override void Rotate()
    {
        
    }

    public void OnJump(InputValue inputValue)
    {
        if(inputValue.isPressed && !isJump)
        {
            Vector3 velocity = _rigidbody.velocity;
            velocity.y += jumpForce;
            _rigidbody.velocity = velocity;
            isJump = true;
        }
    }
}
