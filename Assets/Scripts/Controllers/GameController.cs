using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] private Data data;
    [SerializeField] private Location spawnLocation;
    [SerializeField] private PlayerControlelr player;
    void Start()
    {
        data = FindObjectOfType<Data>().GetComponent<Data>();
        spawnLocation = GameObject.Find(data.GetCurrentLocation()).GetComponent<Location>();
        player.transform.position = spawnLocation.GetSpawnPoint().position;
    }

    public void BackToWorldMenu()
    {
        SceneManager.LoadScene("World Map");
    }
}
