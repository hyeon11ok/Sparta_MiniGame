using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour, ITrigger
{
    private Vector2 startPos;

    private void Start()
    {
        startPos = FindObjectOfType<BasePlayerController>().transform.position;
    }

    public void TriggerEnterEvent(GameObject gameObject)
    {
        gameObject.transform.position = startPos;
    }
}
