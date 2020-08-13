using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{
    Image healthbarFilling;
    public int maxHealth;
    int health;
    private void Start()
    {
        healthbarFilling = this.GetComponent<Image>();
        health = maxHealth;
        
    }
    public void addHealth(int value)
    {
        health += value;
        if (health > maxHealth)
            health = maxHealth;
        updateHealth();

    }
    public bool removeHealth(int value)
    {
        health -= value;
        if (health <= 0)
        {
            health = 0;
            updateHealth();
            return true;
        }
        updateHealth();
        return false;
    }
    public void updateHealth()
    {
        healthbarFilling.fillAmount = health / maxHealth;
    }
}
