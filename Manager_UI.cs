using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Manager_UI : MonoBehaviour
{
    public GameObject gameOverScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void restartGame()
    {

        SceneManager.LoadScene("Menu");
    }
    public void endGameScreen()
    {

        gameOverScreen.SetActive(true);
    }
    

   
}
