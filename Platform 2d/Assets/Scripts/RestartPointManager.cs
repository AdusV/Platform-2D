using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartPointManager : MonoBehaviour
{
    public PlayerController playerController;
    public void UpdateStartPoint(Transform newTransform)
    {
        playerController.startPoint = newTransform;
    }
}
