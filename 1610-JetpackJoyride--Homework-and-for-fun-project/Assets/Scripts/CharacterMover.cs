using System;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    //Public Variables
    public CharacterController controller;
    public float moveSpeed = 5.0f, gravity = -9.81f, jumpForce = 5.0f;
    
    //Private Variables
    private Vector3 moveDirection;
    private float yDirection;
    
    private void Update()
    {
        // LEFT and RIGHT MOVEMENT
        var moveSpeedInput = moveSpeed * Input.GetAxis("Horizontal"); // Takes player input and uses it as a scaler to make the character move
        moveDirection.Set(moveSpeedInput,yDirection,0); // Converts the player input into a left or right movement
        
        // GRAVITY and JUMPING
        yDirection += gravity * Time.deltaTime; // Adds gravity every second to simulate the acceleration of adding 9.81m/s^2 to the y in the downward force
        if (controller.isGrounded && moveDirection.y < 0) { yDirection = -1f; } // Small downward force if player is grounded
        if (Input.GetButtonDown("Jump")) { yDirection = jumpForce; } // Makes the character jump when the spacebar is pressed
        var movement = moveDirection * Time.deltaTime; // Uses Time.deltaTime as a scaler to make it more uniform
        controller.Move(movement); // Finaly this sends the movement to the character
    }
}
