using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_management : MonoBehaviour
{

    void Start()
    {
        //Debug.Log(SceneManager.sceneCount);
        //Debug.Log(SceneManager.sceneCountInBuildSettings);

        //// 1
        //Scene activeScene = SceneManager.GetActiveScene();
        //Debug.Log("Active Scene's name is --->  " + activeScene.name);

        //// 2
        //Scene otherScene = SceneManager.GetSceneAt(0);
        //Debug.Log("Other Scene's name is --->  " + otherScene.name);
        //Debug.Log("Is the scene loaded? --->  " + otherScene.isLoaded);
        ////Debug.Log(otherScene.isLoaded ? "True":"False");

        //// 3
        //Scene otherBuildScene = SceneManager.GetSceneByBuildIndex(1);
        //Debug.Log("Other Build Scene's name is --->  " + otherBuildScene.name);

        //// 4
        //Scene sceneByName = SceneManager.GetSceneByName("transform_process");
        //Debug.Log("Scene Build Index: --->  "+sceneByName.buildIndex);


        // Load a Scene
        SceneManager.LoadScene("transform_process", LoadSceneMode.Single);

        SceneManager.sceneUnloaded += MyUnloadProcess;
        SceneManager.sceneLoaded += MyLoadProcess;



    }


    public void MyLoadProcess(Scene scene, LoadSceneMode mode)
    {
        Debug.Log(scene.name + "  Scene Loaded");
    }

    public void MyUnloadProcess(Scene unloadScene)
    {
        Debug.Log(unloadScene.name + " Scene Unloaded");
    }

}
