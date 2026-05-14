using System;
using System.Collections.Generic;
using UnityEngine;


namespace Script
{
    public class PlayerMovement : MonoBehaviour
    {
        public float moveSpeed;
        public float rotationSpeed;
        public PlayerInput playerInput;
        Rigidbody2D rb;

        private void OnEnable()
        {
            playerInput = new PlayerInput();
            playerInput.Enable();
            rb = GetComponent<Rigidbody2D>();
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }

        void FixedUpdate()
        {
            RotatePlayer();
            MovePlayer();
        }
        
        void MovePlayer()
        {
            Vector2 axis = playerInput.FindAction("Walk").ReadValue<Vector2>();
            Vector2 forwardMove = transform.up * axis.y;
            Vector2 sideMove = transform.right * axis.x;
            
            Vector2 finalVelocity = (forwardMove + sideMove).normalized * moveSpeed;

            rb.velocity = finalVelocity;
        }

        void RotatePlayer()
        {
            var input = playerInput.FindAction("Rotate").ReadValue<Vector2>();
            float rotationAmount = input.x * rotationSpeed * Time.deltaTime;
            transform.Rotate(0, 0, -rotationAmount ); 
        }
    }
}
