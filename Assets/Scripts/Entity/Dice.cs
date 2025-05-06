using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{
    [SerializeField] private Button[] numbers;
    [SerializeField] private float shuffleTerm;
    [SerializeField] private int shuffleEndCount; // �ֻ��� ���� Ƚ��
    private int shuffleCount = 0;

    // Update is called once per frame
    void Update()
    {
        if(shuffleCount == shuffleEndCount)
        {
            CancelInvoke("NextNumber");
            shuffleCount = 0;
            // TODO : ��ư �̺�Ʈ �ڵ鷯 Ȱ��ȭ
        }
    }

    public void StartShuffle()
    {
        // TODO : �ֻ��� ���� ���� ���� ����
        InvokeRepeating("NextNumber", 0, shuffleTerm);
    }

    public void NextNumber()
    {
        // TODO : ���� ���� Ȱ��ȭ ����
        Debug.Log("Next Number");
        shuffleCount++;
    }
}
