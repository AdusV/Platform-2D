using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform navStartPoint;
    public Transform navEndPoint;

    private Vector2 startPoint;
    private Vector2 endPoint;
    public float speed;

    private Vector2 currentPlatformPosition;
    private void Start()
    {
        startPoint = navStartPoint.position;
        endPoint = navEndPoint.position;
        Destroy(navStartPoint.gameObject);
        Destroy(navEndPoint.gameObject);
    }
    private void Update()
    {
        currentPlatformPosition = Vector2.Lerp(startPoint, endPoint, Mathf.PingPong(Time.time * speed, 1));
        transform.position = currentPlatformPosition;   
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
        other.transform.parent = transform;
        other.attachedRigidbody.Sleep();
        }
       
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.transform.parent = null;
        }
    
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        other.attachedRigidbody.velocity += new Vector2(speed, 0);
    }

}
