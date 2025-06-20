using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool isPlayer1;
    public Rigidbody2D rgb;
    public float speed;

    
    void Update()
    {
        if (isPlayer1)
        {
            rgb.linearVelocity = Vector2.up * speed * Input.GetAxisRaw("Vertical");
        }
        else
        {
            rgb.linearVelocity = Vector2.up * speed * Input.GetAxisRaw("VerticalPlayer2");
        }
    }
}
