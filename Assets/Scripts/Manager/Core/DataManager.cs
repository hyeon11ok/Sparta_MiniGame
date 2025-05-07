using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance { get; private set; }

    private List<MiniGameData> miniGameDatas = new List<MiniGameData>();

    public List<MiniGameData> MiniGameDatas { get { return miniGameDatas; } }

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

        miniGameDatas.Add(new MiniGameData("RunningGame", SceneName.Running));
        miniGameDatas.Add(new MiniGameData("StackGame", SceneName.TheStack));
        miniGameDatas.Add(new MiniGameData("CountingGame", SceneName.CountingNum));

        foreach(MiniGameData data in miniGameDatas)
        {
            data.ScoreInit(LoadData(data));
        }
    }

    public void SaveData(MiniGameData miniGame)
    {
        PlayerPrefs.SetString(miniGame.GameName, miniGame.ScoreRank);
    }

    public string LoadData(MiniGameData miniGame)
    {
        return PlayerPrefs.GetString(miniGame.GameName, "");
    }

    private void OnApplicationQuit()
    {
        foreach(MiniGameData data in miniGameDatas)
        {
            SaveData(data);
        }
    }
}
