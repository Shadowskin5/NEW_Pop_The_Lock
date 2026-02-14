using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public Color startColor;
    public Color loseColor;
    Camera _cam;

    // Start is called before the first frame update
    void Start()
    {
        _cam = GetComponent<Camera>();
        _cam.backgroundColor = startColor;
    }

    public void changeToLoseColor()
    {
        _cam.backgroundColor = loseColor;
    }

    public void changeToStartColor()
    {
        _cam.backgroundColor = startColor;
    }

}
