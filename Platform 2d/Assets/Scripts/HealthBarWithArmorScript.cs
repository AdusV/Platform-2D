using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarWithArmorScript : MonoBehaviour
{
    public GameObject[] armor;
    private int piecesOfArmor;
    Image healthbarFilling;
    public int maxHealth;
    int health;
    private void Start()
    {
        healthbarFilling = this.GetComponent<Image>();
        health = maxHealth;
        piecesOfArmor = armor.Length;
    }
    public void updateArmor()
    {
        for (int i = 0; i < armor.Length; i++)
        {
            if(i<piecesOfArmor)
            {
                armor[i].SetActive(true);

            }
            else
            {
                armor[i].SetActive(false);
            }
        }
    }
    public void addArmor()
    {
        if(piecesOfArmor < armor.Length)
        {
            piecesOfArmor++;
            updateArmor();
        }
    }
    public bool damage(int value)
    {
        if(piecesOfArmor>0)
        {
            piecesOfArmor--;
            updateArmor();
            return false;
        }
        else
        {
            return damageIgnoringArmor(value);
        }
    }
    public bool damageIgnoringArmor(int value)
    {
        health -= value;
        if (health <= 0)
        {
            health = 0;
            updateHealthBar();
            return true;
        }
        updateHealthBar();
        return false;
    }
    public void addHealth(int value)
    {
        health += value;
        if (health > maxHealth)
            health = maxHealth;
        updateHealthBar();
    }
    public void updateHealthBar()
    {
        healthbarFilling.fillAmount = health / maxHealth;

    }
    
}
