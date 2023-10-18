using UnityEngine;
using UnityEngine.UI;

public class Location : MonoBehaviour
{
    [SerializeField] private Button locationButton;
    [SerializeField] private Image unavailableSprite;

    private void Start()
    {
        if (unavailableSprite.gameObject.activeSelf)
            locationButton.interactable = false;
        else
            locationButton.interactable = true;
    }

    public void SetAvailable()
    {
        locationButton.interactable |= true;
        unavailableSprite.gameObject.SetActive(false);
    }

    public Button GetLocation()
    {
        return locationButton;
    }
}
