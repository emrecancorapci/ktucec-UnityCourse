using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public float JumpForce;
    private bool isGround;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            _rigidbody.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
            isGround = false;
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGround = true;
        }
    }
}
