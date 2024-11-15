using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Transform groundChecker;
    [SerializeField] LayerMask groundLayer;
    Rigidbody2D rb2d;
    Animator animator;
    SpriteRenderer spriteRenderer;
    int movementDirection = 0;
    float movementSpeed = 5f;
    bool isFacingRight = true;
    float jumpForce = 15f;
    bool isGrounded = false;

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        if (context.ReadValue<Vector2>().x > 0)
        {
            movementDirection = 1;
        }
        else if (context.ReadValue<Vector2>().x < 0)
        {
            movementDirection = -1;
        }
        else
        {
            movementDirection = 0;
        }
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.started && isGrounded)
        {
            rb2d.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        }
    }   

    void FixedUpdate()
    {
        rb2d.velocity = new Vector2(movementDirection * movementSpeed, rb2d.velocity.y);

        isGrounded = Physics2D.OverlapCircleAll(groundChecker.position, 0.3f, groundLayer).Length > 0;

        if (!isFacingRight && movementDirection == 1 || isFacingRight && movementDirection == -1)
        {
            spriteRenderer.flipX = !spriteRenderer.flipX;
            isFacingRight = !isFacingRight;
        }

        animator.SetBool("run", movementDirection != 0);
        animator.SetBool("grounded", isGrounded);
    }

    public bool canFire()
    {
        return movementDirection == 0 && isGrounded;
    } 

    public bool getIsFacingRight()
    {
        return this.isFacingRight;
    }
}   