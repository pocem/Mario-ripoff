using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jump = 3f;
    public float moveSpeed = 3f;
    private bool canJump;
    public Manager_UI manager;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
  
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);
        rb.velocity = movement;


        if (Input.GetKeyDown(KeyCode.UpArrow) && canJump)
        {
            Jump();
        }

        void Jump()
        {
            rb.velocity = new Vector3(rb.velocity.x, jump);
            canJump = false;
        }
        if (transform.position.y < -5f && (GameObject.FindGameObjectsWithTag("Coin").Length > 0 ))
        {
           manager.endGameScreen();
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            canJump = true; 
        }   
    }  
}

