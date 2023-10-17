using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToNextLvl : MonoBehaviour
{
    Scene currentScene;
    string currentSceneName;
    int currentSceneIndex;
    private void Start()
    {
        currentScene = SceneManager.GetActiveScene();

        currentSceneName = currentScene.name;
        currentSceneIndex = Convert.ToInt32(currentSceneName[currentSceneName.Length - 1].ToString());
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (SceneManager.GetSceneByName($"Location {currentSceneIndex + 1}") != null)
            SceneManager.LoadScene($"Location {currentSceneIndex + 1}");
        else
            Debug.Log("Такой сцены не существует");
    }
}
