using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterController : MonoBehaviour
{
    int numberOfBoxes;
    public Text counterView;

    private void Start()
    {
        ResetCounter();
    }
    //GUI dla skrzynek
    public void IncrementCounter()
    {
        numberOfBoxes++;
        counterView.text = numberOfBoxes.ToString();
    }
    //Wyzerowanie GUI
    public void ResetCounter()
    {
        numberOfBoxes = 0;
        counterView.text = numberOfBoxes.ToString();
    }
}
