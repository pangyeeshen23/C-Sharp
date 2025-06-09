using UnityEngine;

public class CharController : MonoBehaviour
{
    public Transform rayStart;

    private Rigidbody rb;
    private bool walkingRight = true;
    private Animator anim;
    private GameManager gameManager;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        gameManager = FindFirstObjectByType<GameManager>();
    }

    private void FixedUpdate()
    {
        if (!gameManager.gameStarted) return;
        else
        {
            anim.SetTrigger("StartRunning");
            rb.transform.position = transform.position + transform.forward * 2 * Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Crystal")
        {
            Destroy(other.gameObject);
            gameManager.IncreaseScore();
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SwitchDirection();
        }
        RaycastHit hit;
        if (!Physics.Raycast(rayStart.position, -transform.up, out hit, Mathf.Infinity))
        {
            if(rayStart.position.y < 1.5)
                anim.SetTrigger("IsFalling");
        }
        
        if (transform.position.y < -2) gameManager.EndGame();
    }

    private void SwitchDirection()
    {
        if (!gameManager.gameStarted) return;
        walkingRight = !walkingRight;
        if (walkingRight) rb.transform.rotation = Quaternion.Euler(0, 45, 0);
        else rb.transform.rotation = Quaternion.Euler(0, -45, 0);
    }
}
