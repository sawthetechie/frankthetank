using System;
using Script;
using UnityEngine;

public class ShootingSystem : MonoBehaviour
{
    public PlayerMovement PlayerMovement;
    public LineRenderer lineRenderer;
    PlayerInput playerInput;
    public float laserRange;

    private void Start()
    {
        lineRenderer = gameObject.GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerMovement.playerInput.FindAction("Shoot").IsPressed())
        {
            lineRenderer.enabled = true;
            ShootLaser();
        }
        else
        {
            lineRenderer.enabled = false;
        }
    }

    void ShootLaser()
    {
        Vector3 startPos = transform.position;
        
        Vector3 direction = transform.up; 

        Vector3 endPos = startPos + (direction * laserRange);

        // Update the LineRenderer
        lineRenderer.SetPosition(0, startPos);
        lineRenderer.SetPosition(1, endPos);
    }
    
}
