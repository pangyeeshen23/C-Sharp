using UnityEngine;

public class RacketPlayer1 : MonoBehaviour
{
    public float movementSpeed;
    public string AxisName;

    private void FixedUpdate()
    {
        float v = Input.GetAxisRaw(AxisName);
        GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, v) * movementSpeed;
    }

}
