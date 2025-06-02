using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour
{
    public float speed;
    public float extraSpeedPerHit;
    public float maxSpeed;
    
    int hitCounter = 0;

    void Start()
    {
        StartCoroutine(StartBall());
    }


    public IEnumerator StartBall(bool isStartingPlayer1 = true)
    {
        this.hitCounter = 0;
        this.PositionBall(isStartingPlayer1);
        yield return new WaitForSeconds(2);
        if(isStartingPlayer1)
            this.MoveBall(new Vector2(-1, 0));
        else 
            this.MoveBall(new Vector2(1, 0));
    }
    void PositionBall(bool isStartingPlayer1)
    {
        this.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, 0);
        if (isStartingPlayer1)
        {
            this.gameObject.transform.localPosition = new Vector2(-100, 0);
        }
        else
        {
            this.gameObject.transform.localPosition = new Vector2(100, 0);
        }
    }

    public void MoveBall(Vector2 direction)
    {
        direction = direction.normalized;
        float speed = this.speed + (this.hitCounter * this.extraSpeedPerHit);
        Rigidbody2D rb = this.gameObject.GetComponent<Rigidbody2D>();
        rb.linearVelocity = direction * speed;
        Debug.Log("Ball moved with speed: " + rb.linearVelocity.magnitude);
    }

    public void IncreaseHitCounter()
    {
        if(this.hitCounter * this.extraSpeedPerHit <= this.maxSpeed)
            this.hitCounter++;
    }
}
