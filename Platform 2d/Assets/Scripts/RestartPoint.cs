using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartPoint : MonoBehaviour
{
    RestartPointManager restartPointManager;
    SpriteRenderer sprRenderer;
    private void Start()
    {
       restartPointManager = GameObject.Find("Manager").GetComponent<RestartPointManager>();
        if (restartPointManager == null)
        {
            Debug.LogError("Error");
        }
        sprRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            restartPointManager.UpdateStartPoint(this.gameObject.transform);
            sprRenderer.color = new Color(0.3f, 0.6f, 0.6f);
        }
    }
}
