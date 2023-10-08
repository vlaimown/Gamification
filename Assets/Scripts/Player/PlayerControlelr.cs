using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerControlelr : MonoBehaviour
{
    private PlayerMovement playerMovement;
    
    private float horizontalDirection = 0f;
    private float verticalDirection = 0f;
    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    void Update()
    {
        horizontalDirection = Input.GetAxisRaw(GlobalStringVars.HORIZONTAL_AXIS);
        verticalDirection = Input.GetAxisRaw(GlobalStringVars.VERTICAL_AXIS);

        Vector2 direction = new Vector2(horizontalDirection, verticalDirection);

        playerMovement.Move(direction);
    }
}
