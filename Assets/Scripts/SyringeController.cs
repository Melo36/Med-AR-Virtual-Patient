using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyringeController : MonoBehaviour
{
    [SerializeField] private KokoroTTSSpeaker ttspeaker;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Arm"))
        {
            Debug.Log("Arm detected");
            ttspeaker.Speak("Ow ow, that hurts");
        }
    }
}
