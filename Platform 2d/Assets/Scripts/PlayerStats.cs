using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
   [SerializeField] private int maxHp = 100;
   public int hp;
    private void Start()
    {
        hp = maxHp;
    }
    public void Damage(int damage)
    {
        hp -= damage;
    }
}
