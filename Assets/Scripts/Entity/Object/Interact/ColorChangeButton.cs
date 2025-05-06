using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ButtonType
{
    Red,
    Blue
}

public class ColorChangeButton : MonoBehaviour, IInteractive
{
    private static readonly int IsMoving = Animator.StringToHash("IsClick");

    private Animator animator;

    [SerializeField] private ButtonType buttonType;
    [SerializeField] private GameObject[] changeObjects;

    private void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    public void InteractEvent()
    {
        animator.SetTrigger(IsMoving);

        foreach(GameObject obj in changeObjects)
        {
            obj.SetActive(false);
        }

        changeObjects[(int)buttonType].SetActive(true);
    }
}
