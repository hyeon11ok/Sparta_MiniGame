using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{
    [SerializeField] private Button[] numbers;
    [SerializeField] private float shuffleTerm;
    [SerializeField] private int shuffleEndCount; // 주사위 섞기 횟수
    private int shuffleCount = 0;

    // Update is called once per frame
    void Update()
    {
        if(shuffleCount == shuffleEndCount)
        {
            CancelInvoke("NextNumber");
            shuffleCount = 0;
            // TODO : 버튼 이벤트 핸들러 활성화
        }
    }

    public void StartShuffle()
    {
        // TODO : 주사위 숫자 섞기 로직 시작
        InvokeRepeating("NextNumber", 0, shuffleTerm);
    }

    public void NextNumber()
    {
        // TODO : 다음 숫자 활성화 로직
        Debug.Log("Next Number");
        shuffleCount++;
    }
}
