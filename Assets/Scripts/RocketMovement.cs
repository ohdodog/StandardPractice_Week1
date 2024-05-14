﻿using UnityEngine;
using UnityEngine.InputSystem;

public class RocketMovement : MonoBehaviour
{
    private Rigidbody2D _rb2d;
    private bool _isBoosted;
    private readonly float SPEED = 5f;
    private readonly float ROTATIONSPEED = 0.01f;

    private Vector2 movementDirection = Vector2.zero;


    private void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Move(movementDirection);
    }

    public void ApplyMovement(Vector2 direction)
    {
        // TODO : 회전을 적용하고 이동을 적용함 -> 이에 대한 구현을 아래에서 진행할 것
        // Rotate(direction);
        // Move();
        movementDirection = direction;
    }

    public void ApplyBoost(bool isPressed)
    {
        _isBoosted = isPressed;
    }

    private void Rotate(Vector2 direction)
    {
        // TODO : 완만한 회전을 적용함
        
    }

    private void Move(Vector2 direction)
    {
        // TODO : 움직임 적용

        if (_isBoosted)
        {
            direction = direction * SPEED * 3;
            _rb2d.velocity = direction;
        }
        else
        {
            direction = direction * SPEED;
            _rb2d.velocity = direction;
        }
    }
}