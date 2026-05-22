using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OthoscopeController : MonoBehaviour
{
    [SerializeField] private GameObject hearingState;
    [SerializeField] private KokoroTTSSpeaker ttspeaker;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ear"))
        {
            Debug.Log("Ear detected");
            ttspeaker.Speak("That tickles my ear");
            hearingState.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ear"))
        {
            hearingState.SetActive(false);
        }
    }
}
