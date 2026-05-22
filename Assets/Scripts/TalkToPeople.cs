using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class TalkToPeople : MonoBehaviour
{
    [SerializeField] private Transform vrCamera;
    [SerializeField] private Transform target;
    [SerializeField] private float acceptableAngle = 45;
    private float checkInterval = 0f;

    [SerializeField] private ConversationHandler conversationHandler;
    [SerializeField] private STTHandler sttHandler;
    [SerializeField] private KokoroTTSSpeaker ttsHandler;
    [SerializeField] private AssistantInstructions assistant;

    private float dotThreshold;
    private float timer = 0f;
    private bool wasLooking = false;
    bool conversationStarted = false;

    private void Start()
    {
        dotThreshold = Mathf.Cos(acceptableAngle * Mathf.Deg2Rad);
        vrCamera = transform; 
    }

    private void Update()
    {
        /*if (!assistant.finishedIntstructions)
        {
            return;
        }*/

        if (sttHandler.playerStartedSpeaking || ttsHandler.isPlaying)
        {
            return;
        }
        timer += Time.deltaTime;
        if (timer >= checkInterval)
        {
            timer = 0f;
            CheckLookDirection();
        }
    }

    void CheckLookDirection()
    {
        Vector3 directionToTarget = (target.position - vrCamera.position).normalized;
        Vector3 cameraForward = vrCamera.forward;

        float dot = Vector3.Dot(cameraForward, directionToTarget);
        bool isLooking = dot > dotThreshold;

        if (isLooking)
        {
            Debug.Log("Looking at patient");
            if (!conversationStarted)
            {
                conversationStarted = true;
                conversationHandler.StartConversation();
            }
            
        }
        else
        {
            Debug.Log("Not looking");
            if (conversationStarted)
            {
                conversationStarted = false;
                conversationHandler.StopConversation();
            }
        }
    }
}
