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
        // TODO : Ÿ�Կ� ���� ������Ʈ Ȱ��ȭ
    }
}
