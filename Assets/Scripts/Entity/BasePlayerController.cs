using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BasePlayerController : MonoBehaviour
{
    protected Rigidbody2D _rigidbody;
    protected SpriteRenderer characterRenderer;
    protected Animator animator;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        characterRenderer = GetComponentInChildren<SpriteRenderer>();
        animator = GetComponentInChildren<Animator>();
    }

    protected virtual void Update()
    {
        Rotate();
    }

    protected virtual void FixedUpdate()
    {
        Move();
    }

    public abstract void Move();
    public abstract void Rotate();
}
