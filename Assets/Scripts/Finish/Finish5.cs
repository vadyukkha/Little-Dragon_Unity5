using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fihish5 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {   
            PlayerMoney.currentCountCoins = 0;
            SceneManager.LoadScene(6);
            Scenes.lastScene = 1;
        }
    }
}
