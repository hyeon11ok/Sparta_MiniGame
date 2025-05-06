using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TopDownPlayerController : BasePlayerController
{
    private static readonly int IsMoving = Animator.StringToHash("IsMove");

    [SerializeField] private float speed;
    private Vector2 moveDir;
    private Vector2 lookDir;

    [SerializeField] private float interactRange;
    [SerializeField] private float centerTemp;

    public override void Move()
    {
        Vector2 dir = moveDir * speed;

        _rigidbody.velocity = dir;

        animator.SetBool(IsMoving, dir.magnitude > 0.5f);
    }

    public override void Rotate()
    {
        float rotZ = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        bool isLeft = Mathf.Abs(rotZ) > 90f;

        characterRenderer.flipX = isLeft;
    }

    public void OnMove(InputValue inputValue)
    {
        moveDir = inputValue.Get<Vector2>().normalized;
    }

    public void OnLook(InputValue inputValue)
    {
        Vector2 mousePosition = inputValue.Get<Vector2>();
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(mousePosition);
        lookDir = (worldPos - (Vector2)transform.position);

        if(lookDir.magnitude < 0.9f)
        {
            lookDir = Vector2.zero;
        }
        else
        {
            lookDir = lookDir.normalized;
        }
    }

    public void OnInteraction(InputValue inputValue)
    {
        if(inputValue.isPressed)
        {
            Collider2D[] hit = Physics2D.OverlapCircleAll(transform.position + (Vector3.up * centerTemp), interactRange, 1 << 7);
            if(hit.Length > 0)
            {
                hit[0].GetComponent<IInteractive>().InteractEvent();
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position + (Vector3.up * centerTemp), interactRange);
    }
}
