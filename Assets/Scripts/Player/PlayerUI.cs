using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] Text textCoinsCount;
    [SerializeField] Text textFireballsCount;

    void FixedUpdate()
    {   
        textCoinsCount.text = PlayerMoney.currentCountCoins.ToString();
        textFireballsCount.text = PlayerFire.currentCountFireballs.ToString();
    }
    
}
