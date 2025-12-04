using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{

    public int speed = 55;

    Transform _anchor;

    bool isRunning = false;

    public Direction _direction = Direction.clockwise;


    void Start()
    {
        _anchor = GameObject.FindGameObjectWithTag("Anchor").transform;
    }

    void Update()
    {
        if (isRunning)
        {
            transform.RotateAround(_anchor.position, Vector3.forward, speed * Time.deltaTime * -(int)_direction);
        }

        if (mouseClick)
        {
            if (!isRunning)
            {
                isRunning = true;
                return;
            }
            ChangeDirection();
        }
    }

    bool mouseClick
    {
        get
        {
            return Input.GetMouseButtonDown(0);
        }
    }

    void ChangeDirection()
    {
        switch(_direction)
        {
            case Direction.clockwise:
                _direction = Direction.antiClockwise;
                break;
            case Direction.antiClockwise:
                _direction = Direction.clockwise;
                break;
        }
    }
}

public enum Direction
{
    clockwise = 1,
    antiClockwise = -1
}
