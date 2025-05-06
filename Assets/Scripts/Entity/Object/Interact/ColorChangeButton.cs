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
    [SerializeField] private ButtonType buttonType;
    [SerializeField] private GameObject[] changeObjects;

    public void InteractEvent()
    {
        // TODO : 타입에 따라 오브젝트 활성화
    }
}
