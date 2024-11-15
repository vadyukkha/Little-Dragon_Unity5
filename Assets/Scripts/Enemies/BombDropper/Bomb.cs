using UnityEngine;
using UnityEngine.SceneManagement;

public class Bomb : MonoBehaviour
{
    Rigidbody2D rb2d;
    [SerializeField] float speed = 4f;

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb2d.velocity = new Vector2(rb2d.velocity.x, -speed);
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
}
