using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Image))]

public class ChangeColorButton : MonoBehaviour
{
    public Color color;
    Color colorOrginal;
    Image img;
    bool b;
    private void Start()
    {
        img = GetComponent<Image>();
        colorOrginal = img.color;
    }
    public void Onclick()
    {
        if (b)

            img.color = color;

        else
            img.color = colorOrginal;
        b = !b; 

    }
}
