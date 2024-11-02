using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class JumpScript : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    private  Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector3(rb.velocity.x, speed, rb.velocity.z);
        }
    }
}
