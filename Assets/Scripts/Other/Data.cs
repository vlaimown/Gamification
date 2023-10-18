using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Data : MonoBehaviour
{
    [SerializeField] 
    private static string currentLocation = "Location 1";

    [SerializeField] 
    private static List<string> availableLocations = new List<string>();

    private void Start()
    {
        availableLocations.Add("Location 1");
    }

    public void UnlockLocation(string location)
    {
        if (IsAvailableLocation(location) == false)
            availableLocations.Add(location);
    }

    public bool IsAvailableLocation(string location)
    {
        return availableLocations.Contains(location);
    }

    public void SetCurrentLocation()
    {
        currentLocation = EventSystem.current.currentSelectedGameObject.name;
    }

    public string GetCurrentLocation() => currentLocation;
}
