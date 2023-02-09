using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [Header("Animation")]
    [SerializeField] private Animator animator;

    [Header("Fall")]
    [SerializeField] private float fallHeight;

    [SerializeField] private float fallSpeed;

    private float floorY;

    private void Start()
    {
        enabled = false;
    }

    private void Update()
    {
        if (transform.position.y > floorY)
        {
            transform.Translate(0, -fallSpeed * Time.deltaTime, 0);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, floorY, transform.position.z);
            enabled = false;
        }
    }

    public void Jump()
    {
        animator.speed = 1;
    }

    public void Fall() 
    {
        animator.speed = 0;
        enabled = true;
        floorY = transform.position.y - fallHeight;
    }

    public void Stop() 
    {
        animator.speed = 0;
    }
}
