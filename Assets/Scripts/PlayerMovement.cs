using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 moveInput;

    private Camera cam;
    private Vector2 halfSize; // half the player's width/height

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cam = Camera.main;

        // Uses the sprite's bounds so the whole player stays on screen, not just its center
        halfSize = GetComponent<Collider2D>().bounds.extents;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.linearVelocity = moveInput * moveSpeed;

        // Camera edges in world space
        Vector2 min = cam.ViewportToWorldPoint(new Vector3(0, 0, 0));
        Vector2 max = cam.ViewportToWorldPoint(new Vector3(1, 1, 0));

        Vector2 pos = rb.position;
        pos.x = Mathf.Clamp(pos.x, min.x + halfSize.x, max.x - halfSize.x);
        pos.y = Mathf.Clamp(pos.y, min.y + halfSize.y, max.y - halfSize.y);

        rb.position = pos;
    }

    public void OnMove(InputValue movementValue) 
    {
        moveInput = movementValue.Get<Vector2>();
    }
}