using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Logic : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;

    
    public void addScore()
    {
        playerScore++;
        scoreText.text = "$" + playerScore.ToString();
    }
    void Start()
    {
        playerScore  = 0;
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
