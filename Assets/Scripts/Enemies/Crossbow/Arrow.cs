using UnityEngine;
using UnityEngine.SceneManagement;

public class Arrow : MonoBehaviour
{
    Rigidbody2D rb2d;
    float speed = 6f;
    float time = 0f;
    int direction = 0;

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb2d.velocity = new Vector2(direction * speed, rb2d.velocity.y);
        time += Time.fixedDeltaTime;
        if (time > 1)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {   
            PlayerMoney.currentCountCoins = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        Destroy(gameObject);
    }

    public void setDirection(int direction)
    {
        this.direction = direction;
    }
}
