using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxScrolling : MonoBehaviour
{
    public Transform cameraTransform;
    //wspolczynnik parlaksy
    public float parallaxFactor;

    Vector3 prevCameraPostion;
    Vector3 deltaCameraPosition;

    private void Start()
    {
        prevCameraPostion = cameraTransform.position;
    }

    private void Update()
    {
        //roznica przesuniecia kamery
        deltaCameraPosition = cameraTransform.position - prevCameraPostion;
        //pozycja po przeliczneiu efekty paralaksy
        Vector3 parallaxPosition = new Vector3(transform.position.x + (deltaCameraPosition.x * parallaxFactor), transform.position.y, transform.position.x);
        transform.position = parallaxPosition;
        //poprzednia staje sie biezaca pozycja kamery
        prevCameraPostion = cameraTransform.position;
    }
}
