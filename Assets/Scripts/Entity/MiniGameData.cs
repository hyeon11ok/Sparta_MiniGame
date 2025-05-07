using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameData
{
    private string gameName;
    private string scoreRank;
    private int highScore;

    public string GameName { get { return gameName; } }
    public SceneName sceneName { get; set; }
    public string ScoreRank {  get { return scoreRank; } }
    public int HighScore { get { return highScore; } }

    public MiniGameData(string gameName, SceneName sceneName)
    {
        this.gameName = gameName;
        this.sceneName = sceneName;
    }

    public void ScoreInit(string score)
    {
        scoreRank = score; 
    }

    public void AddScore(int score)
    {
        scoreRank += score.ToString() + "/";
        string[] scoreArr = scoreRank.Split('/');
        List<int> scores = new List<int>();

        for(int i = 0; i < scoreArr.Length - 1; i++)
        {
            scores.Add(int.Parse(scoreArr[i]));
        }

        scores.Sort((a, b) => b.CompareTo(a));

        foreach(int i in scores)
        {
            scoreRank += i.ToString() + "/";
        }
    }
}
