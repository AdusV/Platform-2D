using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartGame : MonoBehaviour
{
    public string newLevelName;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Application.LoadLevel(newLevelName);
    }
}
  
