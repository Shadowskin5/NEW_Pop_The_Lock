using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotDetector : MonoBehaviour
{
    GameObject currentDot;

    bool isRunning = false;

    public GameEvent dotMissed;
    public GameEvent dotScored;

    void OnTriggerEnter2D(Collider2D other)
    {
        currentDot = other.gameObject;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        currentDot = null;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!isRunning)
            {
                isRunning = true;
                return;
                
            }
            if (currentDot != null)
            {
                Destroy(currentDot);
                dotScored.Raise();
            }
            else
            {
                dotMissed.Raise();
            }
        }
    }
}
