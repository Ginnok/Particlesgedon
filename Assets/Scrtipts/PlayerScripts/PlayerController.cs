using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    
    Rigidbody2D rb;
    Collider2D myCollider;

    public bool isGrounded;
    public LayerMask whatIsGround;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<Collider2D>();
    }

    void Update()
    {
        moveSpeed += Time.deltaTime* 1;
        isGrounded = Physics2D.IsTouchingLayers(myCollider, whatIsGround);
        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        if (Input.GetButtonDown("Jump"))
        Jump();
    }
    
    private void Jump()
    {
    if(isGrounded)
    {
    rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
    }
    }
}
