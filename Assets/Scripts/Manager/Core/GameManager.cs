using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SceneName
{
    Lobby, 
    Running,
    StackBlock,
    CountingNum
}

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public SceneName CurrentScene { get; private set; }

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    public virtual void ResumeGame()
    {
        // TODO : 게임 실행 로직
        Debug.Log("Resume Game");
    }

    public virtual void PauseGame()
    {
        // TODO : 게임 일시정지 로직
        Debug.Log("Pause Game");
    }

    public void ExitGame()
    {
        // TODO : 게임 종료 로직
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void ChangeScene(SceneName sceneName)
    {
        // TODO : 씬 전환 로직
        Debug.Log($"Change Scene to {sceneName}");
    }
}
