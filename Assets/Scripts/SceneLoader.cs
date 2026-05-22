using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static void QuerySceneInfo(Scene scene)
    {
        Debug.Log("Scene name: " + scene.name);
        Debug.Log("Scene path: " + scene.path);
        Debug.Log("Scene build index: " + scene.buildIndex);
        Debug.Log("Scene is dirty: " + scene.isDirty);
        Debug.Log("Scene is loaded: " + scene.isLoaded);
        Debug.Log("Scene root count: " + scene.rootCount);
    }
    public string sceneToLoad = "child";


    void Start()
    {
        Debug.Log("Scene Loader");
        Scene currentScene = SceneManager.GetActiveScene();
        QuerySceneInfo(currentScene);
    }

    void OnMouseDown()
    {
        Debug.Log("Cube clicked! Loading next scene...");
        SceneManager.LoadScene(sceneToLoad);  // 또는 LoadScene(1); 인덱스로도 가능
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
