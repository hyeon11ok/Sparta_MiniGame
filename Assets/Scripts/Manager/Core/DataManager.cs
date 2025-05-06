using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance { get; private set; }

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SaveScore(SceneName sceneName, ScoreData data)
    {
        // TODO : ������ ���� ����
        Debug.Log($"Save Score for {sceneName}");
    }

    public ScoreData LoadData(string sceneName)
    {
        // TODO : ������ �ε� ����
        Debug.Log($"Load Data for {sceneName}");

        return new ScoreData();
    }
}
