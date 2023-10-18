using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitcher : MonoBehaviour
{
    GameController gameController;

    Scene currentScene;
    string currentSceneName;
    int currentSceneIndex;

    private void Start()
    {
        gameController = GameObject.Find("GameController").GetComponent<GameController>();

        currentScene = SceneManager.GetActiveScene();

        currentSceneName = currentScene.name;
        currentSceneIndex = Convert.ToInt32(currentSceneName[currentSceneName.Length - 1].ToString());
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameController.LoadNextLevel(currentSceneIndex);
    }
}
