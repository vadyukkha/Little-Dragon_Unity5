using UnityEngine;

public class BombDropper : MonoBehaviour
{
    [SerializeField] GameObject bomb;
    [SerializeField] float fireInterval = 1.5f;
    [SerializeField] float distance = 10f;
    [SerializeField] float movementSpeed = 4f;
    int movementDirection = 1;
    float pointA;
    float pointB;
    Rigidbody2D rb2d;
    
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        pointA = transform.position.x;
        pointB = pointA + distance;
        InvokeRepeating("Fire", 0f, fireInterval);
    }

    void Fire()
    {
        GameObject newBomb = Instantiate(bomb, new Vector3(transform.position.x, transform.position.y - 0.5f, 0f), Quaternion.identity);
    }
    
    void Update()
    {
        rb2d.velocity = new Vector2(movementDirection * movementSpeed, 0);

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
