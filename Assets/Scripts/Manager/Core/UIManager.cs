using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UIManager : MonoBehaviour
{
    [SerializeField] protected GameManager gameManager;
    protected UIState curState;
    protected OptionUI option;

    public abstract void Init();
    public abstract void ChangeState(UIState state);
}
