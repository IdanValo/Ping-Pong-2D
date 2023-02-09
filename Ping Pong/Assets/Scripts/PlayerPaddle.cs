using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : Paddle
{
    public Vector2 dir { get; private set; }

    void Update()
    {
        PlayerMove();
    }

    private void FixedUpdate()
    {
        if(dir.sqrMagnitude != 0)
        {
            rigidbody.AddForce(dir * speed);
        }
    }

    void PlayerMove()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            dir = Vector2.up;
        }
        else if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            dir = Vector2.down;
        }
        else
        {
            dir = Vector2.zero;
        }
    }
}
