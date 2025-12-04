using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{

    public int speed = 5;

    Transform _anchor;

    public Direction _direction = Direction.clockwise;


    void Start()
    {
        _anchor = GameObject.FindGameObjectWithTag("Anchor").transform;
    }

    void Update()
    {
        transform.RotateAround(_anchor.position, Vector3.forward, speed * Time.deltaTime * -(int)_direction);
    }
}

public enum Direction
{
    clockwise = 1,
    antiClockwise = -1
}
