using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public int sceneToLoad;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Hand"))
        {
            StartCoroutine(switchScene());
        }
    }

    IEnumerator switchScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(sceneToLoad);
    }
}
