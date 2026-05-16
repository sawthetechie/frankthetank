using System;
using System.Collections.Generic;
using UnityEngine;


namespace Script
{
    public class TankMovement : MonoBehaviour
    {
        [SerializeField] float moveSpeed;
        [SerializeField] float rotateSpeed;
        Rigidbody2D rb;
        
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }
        void FixedUpdate()
        {
            MovePlayer();
            RotatePlayer();
        }
        
        void MovePlayer()
        {
            if (InputManager.Instance == null)
            {
                Debug.Log("Input Manager Not Found");
            }
            
            float axis = InputManager.Instance.Controls.Tank.Walk.ReadValue<float>();
            
            rb.velocity = transform.up * axis *  moveSpeed;
        }

        void RotatePlayer()
        {
            if (InputManager.Instance == null) return;
            float rotateValue = InputManager.Instance.Controls.Tank
                .Rotate
                .ReadValue<float>();

            transform.Rotate(0, 0, -rotateValue * rotateSpeed * Time.deltaTime);
        }
        
    }
}
