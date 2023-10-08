using UnityEngine;

public class PlayerKeyMovement : MonoBehaviour
{
    [SerializeField] private float speed = 0f;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Move(Vector2 direction)
    {
        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
    }
}
