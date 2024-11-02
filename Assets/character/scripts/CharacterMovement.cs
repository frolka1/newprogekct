using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterMovement : MonoBehaviour

{
    private Animator _animator;
    private Rigidbody _rb;

    private float _speed;
    [SerializeField] private float _maxSpeed;



    void Start()
    {
        _animator = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        float movementDirection = Input.GetAxis("Vertical");
        if (movementDirection > 0)
        {
            _animator.SetBool("walk", true);

        }
        else
        {
            _animator.SetBool("walk", false);
        }

         
        if (Input.GetKey(KeyCode.LeftShift))
        {
            _animator.SetBool("run", true);
        }
        else
        {
            _animator.SetBool("run", false);
        }
        
        if(movementDirection > 0)
        {
            _rb.AddForce(transform.forward * _speed, ForceMode.Impulse);
        }
    
        ClampVelocity();


        }
    private void ClampVelocity()
    {

        float velocity = _rb.velocity.magnitude;

        if (velocity > _maxSpeed)
        {
            Vector3 movementDirection = _rb.velocity.normalized;
            _rb.velocity = movementDirection * _maxSpeed;

        }

    }

}