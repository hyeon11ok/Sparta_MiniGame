using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class CharChange : MonoBehaviour, ITrigger
{
    [SerializeField] private AnimatorController animator;

    public void TriggerEnterEvent(GameObject gameObject)
    {
        GameManager.Instance.ChangePlayerAnim(animator);

        TopDownPlayerController playerController;
        if(gameObject.TryGetComponent<TopDownPlayerController>(out playerController))
        {
            playerController.ChangeAnimator();
        }
    }
}
