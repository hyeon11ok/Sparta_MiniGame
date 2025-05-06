using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeLever : MonoBehaviour, IInteractive
{
    [SerializeField] private GameObject activeObj;
    [SerializeField] private Vector2 startPos;

    private SpriteRenderer _renderer;
    [SerializeField] private Sprite leverOn;
    [SerializeField] private Sprite leverOff;
    [SerializeField] private bool isSpikeOnInit = false;
    private bool isSpikeOn;

    private void Awake()
    {
        _renderer = GetComponentInChildren<SpriteRenderer>();
    }

    private void OnEnable()
    {
        isSpikeOn = isSpikeOnInit;
        ChangeObjectActive();
        ChangeLeverSprite();
    }

    public void InteractEvent()
    {
        isSpikeOn = !isSpikeOn;
        FindObjectOfType<BasePlayerController>().transform.position = startPos;

        ChangeObjectActive();

        ChangeLeverSprite();
    }

    private void ChangeObjectActive()
    {
        if(isSpikeOn)
        {
            activeObj.SetActive(true);
            if(activeObj.transform.childCount > 0)
            {
                foreach(Transform child in activeObj.transform)
                {
                    child.gameObject.SetActive(true);
                }
            }
        }
        else
        {
            activeObj.SetActive(false);
        }
    }

    private void ChangeLeverSprite()
    {
        if(isSpikeOn)
        {
            _renderer.sprite = leverOn;
        }
        else
        {
            _renderer.sprite = leverOff;
        }
    }
}
