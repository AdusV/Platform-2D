using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGold : MonoBehaviour
{
    CounterController counterController;
    public AudioClip clip;
   

    private void Start()
    {
        //Szukamy obiektu manager , a w nim skrypt Inkrementacji
        counterController = GameObject.Find("Manager").GetComponent<CounterController>();
        if (counterController == null)
        {
            Debug.LogError("Counter Controller don't Find !!!");
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Girl")
        {
            Destroy(this.gameObject);
            AudioSource.PlayClipAtPoint(clip, transform.position);
            counterController.IncrementCounter();
           
        }
    }
}
