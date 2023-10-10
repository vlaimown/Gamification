using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public float speed = 0f;
    public Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void KeyMove(Vector3 direction) 
    {
        transform.position = transform.position + direction * speed * Time.fixedDeltaTime;
    }

    public void MouseMove(Vector2 target) 
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.fixedDeltaTime);
    }
}
