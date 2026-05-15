using System;
using Script;
using UnityEngine;

public class ShootingSystem : MonoBehaviour
{
    public PlayerMovement PlayerMovement;
    
    PlayerInput playerInput;
    public float laserRange;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ShootLaser()
    {
        Vector3 startPos = transform.position;
        
        Vector3 direction = transform.up; 

        Vector3 endPos = startPos + (direction * laserRange);
        
    }
    
}
