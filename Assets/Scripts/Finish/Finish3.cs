using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fihish3 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {   
            PlayerMoney.currentCountCoins = 0;
            SceneManager.LoadScene(4);
            Scenes.lastScene = 4;
        }
    }
}