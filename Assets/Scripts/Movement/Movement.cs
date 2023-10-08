using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class Movement : MonoBehaviour
{
    [SerializeField] protected float speed = 0f;
    protected Rigidbody2D rb;
    virtual protected void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public virtual void Move(Vector2 direction) { }
}
