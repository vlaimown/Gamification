using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] private Data data;
    [SerializeField] private Location spawnLocation;
    [SerializeField] private PlayerController player;
    void Start()
    {
        player = FindObjectOfType<PlayerController>();
        data = FindObjectOfType<Data>();
        //spawnLocation = GameObject.Find(data.GetCurrentLocation()).GetComponent<Location>();
        //player.transform.position = spawnLocation.GetSpawnPoint().position;
    }

    public void LoadNextLevel(int currentSceneIndex)
    {
        if (SceneManager.GetSceneByName($"Location {currentSceneIndex + 1}") != null)
        {
            bool isUnlocked = false;
            data.UnlockLocation($"Location {currentSceneIndex + 1}");
            while (isUnlocked == false)
                isUnlocked = data.IsAvailableLocation($"Location {currentSceneIndex + 1}");
            SceneManager.LoadScene($"Location {currentSceneIndex + 1}");
        }
        else
            Debug.Log("����� ����� �� ����������");
    }

    public void BackToWorldMenu()
    {
        SceneManager.LoadScene("World Map");
    }
}
