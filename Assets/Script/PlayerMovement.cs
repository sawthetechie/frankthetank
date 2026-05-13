using System;
using System.Collections.Generic;
using UnityEngine;


namespace Script
{
    public class PlayerMovement : MonoBehaviour
    {
        public PlayerInput PlayerInput;
        public float moveSpeed;
        public float rotationSpeed;
        Rigidbody2D rb;

        private void OnEnable()
        {
            PlayerInput = new PlayerInput();
            PlayerInput.Enable();
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
            Vector2 axis = PlayerInput.FindAction("Walk").ReadValue<Vector2>();
            Vector2 forwardMove = transform.up * axis.y;
            Vector2 sideMove = transform.right * axis.x;
            
            Vector2 finalVelocity = (forwardMove + sideMove).normalized * moveSpeed;

            rb.linearVelocity = finalVelocity;
        }

        void RotatePlayer()
        {
            var input = PlayerInput.FindAction("Rotate").ReadValue<Vector2>();
            float rotationAmount = input.x * rotationSpeed * Time.deltaTime;
            transform.Rotate(0, 0, -rotationAmount ); 
        }
    }
}
