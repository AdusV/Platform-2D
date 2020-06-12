using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    PlayerStats playerStats;
    public int damage;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<PlayerStats>().Damage(damage);
            Debug.Log("enemy");
        }
    }

}
