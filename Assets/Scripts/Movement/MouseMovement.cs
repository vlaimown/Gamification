using UnityEngine;

public class MouseMovement : Movement
{
    private Camera cam;
    Vector2 target = new Vector2(0f, 0f);

    override protected void Start()
    {
        base.Start();
        cam = Camera.main;
    }
    private Vector2 OnGUI()
    {
        Event currentEvent = Event.current;
        Vector2 mousePos = new Vector2();
        Vector2 point = new Vector2();

        // compute where the mouse is in world space
        mousePos.x = currentEvent.mousePosition.x;
        mousePos.y = cam.pixelHeight - currentEvent.mousePosition.y;
        point = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 0.0f));

        return point;
    }

    public override void Move(Vector2 direction)
    {
        if (Input.GetMouseButtonDown(0))
        {
            target = OnGUI();
            Debug.Log("ye");
        }
        rb.transform.position = Vector2.MoveTowards(rb.transform.position, target, speed * Time.fixedDeltaTime);
    }
}
