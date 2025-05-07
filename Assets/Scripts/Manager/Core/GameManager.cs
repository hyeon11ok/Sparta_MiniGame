using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.InputSystem;
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

    public bool god;

    [SerializeField] private AnimatorController playerAnim;
    public AnimatorController PlayerAnim { get { return playerAnim; } }

    [SerializeField] private GameObject optionUI;

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
        // TODO : 게임 종료 로직
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void ChangePlayerAnim(AnimatorController playerAnim)
    {
        this.playerAnim = playerAnim;
    }

    public void ChangeScene(SceneName sceneName)
    {
        StartCoroutine(LoadAndCleanup(sceneName.ToString()));
        CurrentScene = sceneName;
    }

    private IEnumerator LoadAndCleanup(string sceneName)
    {
        // 새 씬 비동기 로드
        AsyncOperation loadOp = SceneManager.LoadSceneAsync(sceneName);
        while(!loadOp.isDone)
            yield return null;

        // 사용되지 않는 에셋 언로드
        yield return Resources.UnloadUnusedAssets();

        // 가비지 콜렉터 강제 실행
        System.GC.Collect();
    }

    public void OnOption(InputValue inputValue)
    {
        if(inputValue.isPressed)
        {
            optionUI.SetActive(true);
        }
    }
}
