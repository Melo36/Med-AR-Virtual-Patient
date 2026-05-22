using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        if (animator == null) animator = GetComponent<Animator>();
        if (animator == null) Debug.LogWarning("Animator not assigned!");
        else Debug.Log(animator);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            TriggerCough();
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            TriggerStand();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            TriggerSit();
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            TriggerNervous();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            TriggerTurnLeft();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            TriggerWave();
        }

    }

    public void TriggerSit()
    {
        if (animator != null)
        {
            Debug.Log("sit down triggered");
            animator.SetTrigger("sit");
        }
    }

    public void TriggerStand()
    {
        if (animator != null)
        {
            Debug.Log("stand up triggered");
            animator.SetTrigger("stand");
        }
    }

    public void TriggerCough()
    {
        if (animator != null)
        {
            Debug.Log("cough triggered");
            animator.SetTrigger("cough");
        }
    }

    public void TriggerNervous()
    {
        if (animator != null)
        {
            Debug.Log("nervous triggered");
            animator.SetTrigger("nervous");
        }
    }

    public void TriggerTurnLeft()
    {
        if (animator != null)
        {
            Debug.Log("turn left triggered");
            animator.SetTrigger("turn_left");
        }
    }

    public void TriggerWave()
    {
        if (animator != null)
        {
            Debug.Log("wave triggered");
            animator.SetTrigger("wave");
        }
    }
}
