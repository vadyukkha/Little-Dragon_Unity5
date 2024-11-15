using UnityEngine;
using UnityEngine.SceneManagement;

public class Saw : MonoBehaviour
{
    [SerializeField] float distance = 5f;
    [SerializeField] float movementSpeed = 3f;
    float rotationSpeed = 60f;
    int movementDirection = 1;
    float pointA;
    float pointB;
    Rigidbody2D rb2d;
    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        pointA = transform.position.x;
        pointB = pointA + distance;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {   
            PlayerMoney.currentCountCoins = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    void FixedUpdate()
    {
        rb2d.velocity = new Vector2(movementDirection * movementSpeed, rb2d.velocity.y);

        transform.Rotate(0, 0, rotationSpeed);

        if (transform.position.x > pointB)
        {
            movementDirection = -1;
        }
        else if (transform.position.x < pointA)
        {
            movementDirection = 1;
        }
    }
}