﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HiddenLevel : MonoBehaviour
{
    public string newLevelName;
    private void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(newLevelName);
    }
}