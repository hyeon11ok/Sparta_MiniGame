using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float followSpeed;

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 positionTmp = Vector2.Lerp(transform.position, target.position, followSpeed * Time.deltaTime);
        positionTmp.z = -10;
        transform.position = positionTmp;
    }
}
