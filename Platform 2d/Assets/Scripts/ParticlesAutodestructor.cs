using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlesAutodestructor : MonoBehaviour
{
    private void Start()
    {
        Invoke("Autodestruction", 3f);
    }
    void Autodestruction()
    {
        Destroy(this.gameObject); 
    }
}
