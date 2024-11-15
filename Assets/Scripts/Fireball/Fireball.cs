using UnityEngine;

public class Fireball : MonoBehaviour
{
    Rigidbody2D rb2d;
    Animator animator;
    bool isExploded = false;
    float speed = 6f;
    float time = 0f;
    int direction = 0;

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        if (!isExploded)
        {
            rb2d.velocity = new Vector2(direction * speed, rb2d.velocity.y);
            time += Time.fixedDeltaTime;
            if (time > 3)
            {
                Deactivate();
            }
        }
    }
    
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "IceWall")
        {
            Destroy(other.gameObject);
        }
        isExploded = true;
        rb2d.velocity = new Vector2(0, 0);
        animator.SetTrigger("explode");
    }
    
    void Deactivate()
    {
        Destroy(gameObject);
    }

    public void setDirection(int direction)
    {
        this.direction = direction;
    }
}
