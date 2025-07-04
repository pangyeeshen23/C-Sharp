using UnityEngine;

public class Blade : MonoBehaviour
{
    public float minVelo = 0.1f;
    private Rigidbody2D rb;
    private Vector3 lastMousePos;
    private Vector3 mouseVelo;
    private Collider2D col;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
    }

    private void Update()
    {
        col.enabled = IsMouseMoving();
        SetBladeToMouse();
    }

    private void SetBladeToMouse()
    {
        var mousePos = Input.mousePosition;
        mousePos.z = 10;
        rb.position = Camera.main.ScreenToWorldPoint(mousePos);
    }

    private bool IsMouseMoving()
    {
        Vector3 curMousePos = transform.position;
        float traveled = (lastMousePos - curMousePos).magnitude;
        lastMousePos = curMousePos;

        if (traveled > minVelo) return true;
        else return false;
    }
}
