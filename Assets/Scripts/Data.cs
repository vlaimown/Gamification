using UnityEngine;
using UnityEngine.EventSystems;

public class Data : MonoBehaviour
{
    [SerializeField] private static string currentLocation = "Location 1";

    public void SetCurrentLocation()
    {
        currentLocation = EventSystem.current.currentSelectedGameObject.name;
    }

    public string GetCurrentLocation() => currentLocation;
}
