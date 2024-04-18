using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Coin : MonoBehaviour
{
    private Rigidbody2D coin;
    public static int playerScore;
    public Text scoreText;
    public bool IsCollected;
    // Start is called before the first frame update
    void Start()
    {
        coin = GetComponent<Rigidbody2D>();
        playerScore = 0;
        updateScore();
    }
    public void updateScore()
    {
        scoreText.text = "$" + playerScore.ToString();
    }
    public void addScore()
    {
        playerScore++;
        scoreText.text = "$" + playerScore.ToString();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        

        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            
            Destroy(gameObject);
            addScore();
            IsCollected = true;

        }
    }
}
