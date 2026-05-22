using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyringeAnimator : MonoBehaviour
{
    public Animator animator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("LeftHandAnchor"))
        {
            animator.enabled = true;
        }
    }
}
