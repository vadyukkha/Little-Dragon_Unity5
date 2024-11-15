using UnityEngine;

public class Mechanism : MonoBehaviour
{
    [SerializeField] GameObject arrow;
    float fireInterval = 3;
    
    void Start()
    {
        InvokeRepeating("Fire", 0f, fireInterval);
    }

    void Fire()
    {
        if (transform.localScale.x > 0)
        {
            GameObject newArrow = Instantiate(arrow, new Vector3(transform.position.x + 0.65f, transform.position.y, 0f), Quaternion.identity);
            newArrow.GetComponent<Arrow>().setDirection(1);
        }
        else
        {
            GameObject newArrow = Instantiate(arrow, new Vector3(transform.position.x - 0.65f, transform.position.y, 0f), Quaternion.identity);
            newArrow.GetComponent<Arrow>().setDirection(-1);
            newArrow.GetComponent<SpriteRenderer>().flipX = true;
        }
        
    }
}