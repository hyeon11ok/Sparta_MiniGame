using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BasePlayerController : MonoBehaviour
{
    private Rigidbody2D _rigidbody;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public abstract void Move();
    public abstract void Rotate();
}
