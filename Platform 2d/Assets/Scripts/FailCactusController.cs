﻿    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailCactusController : MonoBehaviour
{
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name=="Girl")
        {
            other.gameObject.GetComponent<Animator>().SetTrigger("fail");
        }
    }
}
