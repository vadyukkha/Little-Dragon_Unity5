using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fihish2 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {   
            PlayerMoney.currentCountCoins = 0;
            SceneManager.LoadScene(3);
            Scenes.lastScene = 3;
        }
    }
}