using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KHHealthBarScript : MonoBehaviour
{
    public Image linearBar;
    public Image radialBar;
    int maxHealth = 1000;
    int health;
    int value;
    private void Start()
    {
        health = maxHealth;
    }
    public void addHealth()
    {
        health += value;
        if (health > maxHealth) 
        {
            health = maxHealth;
        }
        updateKHHealthBar();
    }
    public bool removeHealth()
    {
        health -= value;
        if(health<=maxHealth)
        {
            health = 0;
            updateKHHealthBar();
            return true;
        }
        updateKHHealthBar();
        return false;
    }
    void updateKHHealthBar()
    {
        float ratio = health * 1f / maxHealth;
        Debug.Log(ratio);
        if(ratio>0.6)
        {
            linearBar.fillAmount = (ratio - 0.6f) * 2.5f;
            radialBar.fillAmount = 0.75f;
        }
        else
        {
            linearBar.fillAmount = 0;
            radialBar.fillAmount = 0.75f * ratio * 10f / 6f;
        }
    }
}
