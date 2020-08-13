using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymbolicLiivesCounterScript : MonoBehaviour
{
    public GameObject[] hearts;
    int lives;
    private void Start()
    {
        lives = hearts.Length;
    }
    public bool addLife()
    {
        if (lives < hearts.Length)
        {
            lives++;
            updateSymbolicCounter();
            return true;
        }
        return false;
    }
    public bool loseLife()
    {
        lives--;
        if(lives>0)
        {
            updateSymbolicCounter();
            return false;
        }
        lives = 0;
        updateSymbolicCounter();
        return true;
    }
    void updateSymbolicCounter()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if(i<lives)
            {
                hearts[i].SetActive(true);
            }
            else
            {
                hearts[i].SetActive(false);
            }
        }
    }
}
