using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public BallMovement ballMovement;
    public ScoreController scoreController;

    void BounceFromRacket(Collision2D collision)
    {
        Vector3 ballPosition = this.transform.position;
        Vector3 racketPosition = collision.gameObject.transform.position;

        float racketHeight = collision.collider.bounds.size.y;
        float x;
        if(collision.gameObject.name == "Player1") x = 1;
        else x = -1;
        float y = (ballPosition.y - racketPosition.y) / racketHeight;
        this.ballMovement.IncreaseHitCounter();
        this.ballMovement.MoveBall(new Vector2(x, y));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player1" || collision.gameObject.name == "Player2")
        {
            BounceFromRacket(collision);
        } 
        else if (collision.gameObject.name == "Player1Goal")
        {
            this.scoreController.IncreaseScore("Player2");
        }
        else if (collision.gameObject.name == "Player2Goal")
        {
            this.scoreController.IncreaseScore("Player1");
        }
    }
}
