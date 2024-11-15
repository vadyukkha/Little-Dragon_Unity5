using UnityEngine;
using UnityEngine.SceneManagement;

public class Spikes : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {   
            PlayerMoney.currentCountCoins = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
