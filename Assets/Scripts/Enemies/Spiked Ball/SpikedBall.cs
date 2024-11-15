using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikedBall : MonoBehaviour
{
    [SerializeField] GameObject target;
    float rotationSpeed = 5f;

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
        transform.RotateAround(target.transform.position, Vector3.forward, rotationSpeed);
    }
}
