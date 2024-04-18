using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : MonoBehaviour
{
    private Rigidbody2D alien;
    public Ball Ball;
    public GameObject deathEffect;
    public Manager_UI manager;
    // Start is called before the first frame update
    void Start()
    {
        alien = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(other.gameObject);
            manager.endGameScreen();



        }
    }
}
