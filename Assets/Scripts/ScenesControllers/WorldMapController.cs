using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class WorldMapController : MonoBehaviour
{
    Data data;
    [SerializeField] GameObject locationsFolder;

    private void Start()
    {
        data = GameObject.Find("Data").GetComponent<Data>();

        Location[] locations = locationsFolder.GetComponentsInChildren<Location>();

        foreach (Location location in locations)
        {
            if (data.IsAvailableLocation(location.GetLocation().name))
                location.SetAvailable();
        }
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void SelectLocation()
    {
        SceneManager.LoadScene(EventSystem.current.currentSelectedGameObject.name);
    }
}
