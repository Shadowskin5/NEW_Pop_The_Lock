using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUpdater : MonoBehaviour
{
    public int remainingDots = 10;

    public TMPro.TextMeshPro displayText;

    public void DecrementDots()
    {
        remainingDots--;
        if (remainingDots < 0)
        {
            remainingDots = 0;
        }
    }

    void Start()
    {
        displayText = GetComponent<TMPro.TextMeshPro>();
    }

    void Update()
    {
        displayText.text = remainingDots.ToString();
    }
}
