using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

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
    public bool IsPause { get; private set; } = false;

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

    public virtual void ResumeGame()
    {
        Time.timeScale = 1;
        IsPause = false;
    }

    public virtual void PauseGame()
    {
        Time.timeScale = 0;
        IsPause = true;
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
        StartCoroutine(LoadAndCleanup(sceneName.ToString()));
        CurrentScene = sceneName;
    }

    private IEnumerator LoadAndCleanup(string sceneName)
    {
        // �� �� �񵿱� �ε�
        AsyncOperation loadOp = SceneManager.LoadSceneAsync(sceneName);
        while(!loadOp.isDone)
            yield return null;

        // ������ �ʴ� ���� ��ε�
        yield return Resources.UnloadUnusedAssets();

        // ������ �ݷ��� ���� ����
        System.GC.Collect();
    }
}
