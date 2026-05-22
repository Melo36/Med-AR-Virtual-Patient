using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssistantInstructions : MonoBehaviour
{
    [SerializeField]
    private TTSHandler ttsHandler;
    // Start is called before the first frame update

    public bool finishedIntstructions = false;
    
    void Start()
    {
        StartCoroutine(tutorialInstructions());
    }

    IEnumerator tutorialInstructions()
    {
        yield return new WaitForSeconds(3);
        ttsHandler.Speak("My name is Alex. I am your assistant today.");
        
        yield return new WaitForSeconds(3);
        ttsHandler.Speak("You can talk to people by looking at them and asking questions.");
        
        yield return new WaitForSeconds(3);
        ttsHandler.Speak("Grab your gloves with your hands when you are ready.");

        yield return new WaitForSeconds(3);
        finishedIntstructions = true;
    }
}