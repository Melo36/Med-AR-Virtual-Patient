using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartbeatMeasurement : MonoBehaviour
{
    [SerializeField]
    private AudioSource heartbeat;
    [SerializeField] private KokoroTTSSpeaker ttspeaker;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PatientChest"))
        {
            heartbeat.Play();
        }
        else if (other.gameObject.CompareTag("Belly"))
        {
            ttspeaker.Speak("Please be careful, my stomache is very sensitive");
            heartbeat.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("PatientChest"))
        {
            heartbeat.Stop();
        }
    }
}
