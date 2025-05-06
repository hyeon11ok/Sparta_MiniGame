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
        // TODO : ���� ���� ����
        Debug.Log("Resume Game");
    }

    public virtual void PauseGame()
    {
        // TODO : ���� �Ͻ����� ����
        Debug.Log("Pause Game");
    }

    public void ExitGame()
    {
        // TODO : ���� ���� ����
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void ChangeScene(SceneName sceneName)
    {
        // TODO : �� ��ȯ ����
        Debug.Log($"Change Scene to {sceneName}");
    }
}
