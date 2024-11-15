using UnityEngine;

public class PlayerMoney : MonoBehaviour
{
    public static int currentCountCoins = 0; 

    void Awake()
    {
        currentCountCoins = 0;
    }    
    public void AddCoin()
    {
        ++currentCountCoins;
    }
}