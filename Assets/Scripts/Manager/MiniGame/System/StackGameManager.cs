using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackGameManager:MiniGameManager
{
    private BaseMiniGameUIManager uiManager;

    [SerializeField] private GameObject originBlock;
    private Block curBlock;
    [SerializeField] private Color prevColor;
    [SerializeField] private Color curColor;

    public override void Initialize()
    {
        throw new System.NotImplementedException();
    }

    public void SpawnBlock()
    {
        // TODO : ��� ���� ����
        // ����� ������ �������� ����
        // ����� ��ġ�� ���� ����� ��ġ�� ���� ����
        // ����� ũ��� ���� ����� ũ�⿡ ���� ����
    }

    public void SpawnRubble(int width)
    {
        // TODO : ����� �������� �� ���� ���� ����
        // ������ ������ ���� ����� ����� ����
    }

    public bool PlaceBlock()
    {
        // TODO : ����� �״� ����
        // ����� ��ġ�� ũ�⸦ ����
        // ����� �׿����� Ȯ��
        return true; // ���÷� true ��ȯ
    }

    public void ColorChange()
    {
        // TODO : ��� ���� ���� ����
        // ����� ������ �������� ����
        // ���� ����� ����� �ٸ��� ����
    }
}
