using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;
    
    private float movementX;

    public float forwardForce = 2000f;

    public float sideSpeed = 0;
    
    void Start ()
    {

        rb = GetComponent<Rigidbody>();
        

    }

    void OnMove (InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
    }

       
    // We marked this as "Fixed" Update because we
    // are using it to mess with physics
    void FixedUpdate ()
    {
        Vector3 movement = new Vector3 (movementX, 0.0f, forwardForce * Time.deltaTime);
        
        // Add a forward force
        rb.AddForce(movement * sideSpeed);
        
        

        
    }
}
