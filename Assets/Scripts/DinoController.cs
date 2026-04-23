using UnityEngine;
using UnityEngine.InputSystem;

public class DinoController : MonoBehaviour
{
    public float jumpForce = 12f;
    private Rigidbody2D rb;
    private bool isGrounded = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnJump(InputValue value)
    {
        if (isGrounded)
        {
            rb.linearVelocity = new Vector2(0, jumpForce);
            isGrounded = false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
