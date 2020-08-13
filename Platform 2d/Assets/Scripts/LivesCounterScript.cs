using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesCounterScript : MonoBehaviour
{
    private Text uiText;
    public int maxLives;
    private int lives;
    private void Start()
    {
        lives = maxLives;
        uiText = this.GetComponent<Text>();
        updateLivesCounter();

    }
    public bool addLife()
    {
        if (lives < maxLives) 
        {
            lives ++;
            updateLivesCounter();
            return true;

        }
        return false;
    }
    public bool loseLife()
    {
        if (lives > 0) 
        {
            lives--;
            updateLivesCounter();
            return false;
        }
        lives = 0;
        updateLivesCounter();
        return true;
        

    }
    public void updateLivesCounter()
    {
        uiText.text = "<color=red>Lives</color>: " + lives;
    }
}
