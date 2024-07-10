using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 targetPosition;
    private bool isMoving = false;
    public float moveSpeed = 5f;
    public float stoppingDistance = 0.1f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GlobalScoreManager.ResetScore();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Check if mouse button is clicked
        {
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            isMoving = true;
            Vector2 direction = (targetPosition - rb.position).normalized;
            rb.velocity = direction * moveSpeed;
        }

        if (isMoving)
        {
            float distanceToTarget = Vector2.Distance(rb.position, targetPosition);
            if (distanceToTarget < stoppingDistance)
            {
                rb.velocity = Vector2.zero;
                isMoving = false;
            }
        }
    }
}
