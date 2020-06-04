using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingHero : MonoBehaviour
{
    public GameObject hero;
    //Szybkosc ruchu kamery 
    public float smooth;
    Vector3 currentVelocity;
    private void Update()
    {
        //Jesli hero jest przed transform to ruch kamery jest wzgledem bohatera czyli jak skacze to skacze i kamera, ale jesli  posta spada to kamera nie spada
        Vector3 newCameraPostion = new Vector3(hero.transform.position.x, transform.position.y, transform.position.z);
        //Nadanie plynnosci kamerze
        transform.position = Vector3.SmoothDamp(transform.position, newCameraPostion, ref currentVelocity,smooth) ;
    }
}
