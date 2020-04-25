using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;   

    private float horizontal, vertical;

    public float speed = 5f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        horizontal = Input.GetAxis("Horizontal");

        vertical = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        Move(horizontal, vertical);
    }

    private void Move(float x, float z)
    {
        Vector3 direction = new Vector3(x, 0, z);

        Vector3 movement = direction * speed * Time.deltaTime;

        rb.AddForce(movement);
    }

    
}
