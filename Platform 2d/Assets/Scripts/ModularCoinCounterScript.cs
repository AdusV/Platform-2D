using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ModularCoinCounterScript : MonoBehaviour
{
    public Text uiText;
    int maxCoins = 100;
    int coins = 0;

    private void Start()
    {
        uiText = this.GetComponent<Text>();
        UpdateCoinCounter();
    }
    void UpdateCoinCounter()
    {
        uiText.text = coins.ToString();
    }
    public void addCoins(int value)
    {
        coins += value;
        while (coins >= maxCoins) 
        {
            ApplyModularity();
            UpdateCoinCounter();
        }

    }
    void ApplyModularity()
    {
        coins -= maxCoins;
        GameObject.Find("LivesCounter").GetComponent<LivesCounterScript>().addLife();
            
    }
    public void removeCoins(int value)
    {
        coins -= value;
        if (coins < 0)
            coins = 0;
        UpdateCoinCounter();
    }
}
