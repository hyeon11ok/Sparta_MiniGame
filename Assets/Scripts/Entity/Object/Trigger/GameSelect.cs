using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSelect : MonoBehaviour, ITrigger
{
    private LobbyUIManager uiManager;

    private void Start()
    {
        uiManager = FindObjectOfType<LobbyUIManager>();
    }

    public void TriggerEnterEvent(GameObject gameObject)
    {
        uiManager.ShowSelectUI();
    }
}
