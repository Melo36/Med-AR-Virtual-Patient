using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyringeHandle : MonoBehaviour
{
    public Transform startPoint;
    public Transform endPoint;
    [Range(0f, 1f)] public float moveAmount = 0f;
    public float moveSpeed = 1f;

    void Update()
    {
        // Example: Press W to push, S to pull
        if (Input.GetKey(KeyCode.W))
        {
            moveAmount += moveSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            moveAmount -= moveSpeed * Time.deltaTime;
        }

        // Clamp moveAmount to [0, 1] to prevent overshooting
        moveAmount = Mathf.Clamp01(moveAmount);

        // Lerp position based on moveAmount
        transform.position = Vector3.Lerp(startPoint.position, endPoint.position, moveAmount);
    }
}
