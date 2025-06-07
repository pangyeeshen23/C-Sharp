using UnityEngine;

public class CharController : MonoBehaviour
{
    private Rigidbody rb;
    private bool walkingRight = true;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rb.transform.position = transform.position + transform.forward * 2 * Time.deltaTime;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SwitchDirection();
        }
    }

    private void SwitchDirection()
    {
        walkingRight = !walkingRight;
        if (walkingRight) rb.transform.rotation = Quaternion.Euler(0, 45, 0);
        else rb.transform.rotation = Quaternion.Euler(0, -45, 0);
    }
}
