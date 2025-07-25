using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody2D rgb;
    public float speed;
    public float speedIncreaseRate = 1f;
    void Start()
    {
        float x = UnityEngine.Random.Range(0, 2) == 0 ? -1 : 1;
        float y = UnityEngine.Random.Range(0, 2) == 0 ? -1 : 1;
        rgb.linearVelocity = new Vector2(x * speed, y * speed);
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("RightWall"))
        {
            Debug.Log("Player 1 wins");
        }

        else if (collision.CompareTag("LeftWall"))
        {
            Debug.Log("Player 2 wins");
        }

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rgb.linearVelocity = rgb.linearVelocity.normalized * (rgb.linearVelocity.magnitude + speedIncreaseRate);
    }
}
