using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerMovement playerMovement;

    private float horizontalDirection = 0f;
    private float verticalDirection = 0f;

    private Vector2 target;

    [SerializeField] private bool moveTo = false;
    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        target = transform.position;
    }

    void Update()
    {
        horizontalDirection = Input.GetAxisRaw(GlobalStringVars.HORIZONTAL_AXIS);
        verticalDirection = Input.GetAxisRaw(GlobalStringVars.VERTICAL_AXIS);

        Vector2 direction = new Vector2(horizontalDirection, verticalDirection);

        if (direction != Vector2.zero)
        {
            moveTo = false;
            transform.rotation = Quaternion.LookRotation(Vector3.forward, direction);
            playerMovement.KeyMove(direction);
        }

        if (Input.GetMouseButton(0) && direction == Vector2.zero)
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.rotation = Quaternion.LookRotation(Vector3.forward, target - new Vector2(transform.position.x, transform.position.y));
            moveTo = true;
        }

        if (moveTo)
            playerMovement.MouseMove(target);
    }
}
