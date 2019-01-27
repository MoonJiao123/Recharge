﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 4.0f;

    private Vector2 direction = Vector2.zero;

    // Start is called before the first frame update
    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        CheckInput();

        Move();

        UpdateOrientation();
    }

    private void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            direction = Vector2.left;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            direction = Vector2.right;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            direction = Vector2.up;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            direction = Vector2.down;
        }
    }

    private void Move()
    {
        transform.localPosition += (Vector3)direction * speed * Time.deltaTime;
    }

    //// CODE BASED ON MOVING TUTORIAL --Incomplete
    //private void UpdateOrientation()
    //{
    //    if (direction == Vector2.left)
    //    {
    //    }
    //    else if (direction == Vector2.right)
    //    {
    //    }
    //    else if (direction == Vector2.left)
    //    {
    //    }
    //    else if (direction == Vector2.down)
    //    {
    //    }
    //}
}
