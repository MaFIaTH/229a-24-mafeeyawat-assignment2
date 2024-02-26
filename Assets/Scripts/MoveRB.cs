using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRB : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    
    private Rigidbody _rigidbody;
    private Vector2 _inputVector;
    private Vector3 _moveVector;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    
    private void Update()
    {
        _inputVector.x = Input.GetAxis("Horizontal");
        _inputVector.y = Input.GetAxis("Vertical");
    }
    
    private void FixedUpdate()
    {
        _moveVector.x = _inputVector.x * moveSpeed * Time.fixedDeltaTime;
        _moveVector.y = _rigidbody.velocity.y;
        _moveVector.z = _inputVector.y * moveSpeed * Time.fixedDeltaTime;
        _rigidbody.velocity = _moveVector;
    }
}
