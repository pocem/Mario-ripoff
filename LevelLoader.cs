using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public static Coin coin;
    public Animator transition;
    public float transitionTime = 2f;
    public GameObject coinsCollected;
   
    void Update()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;

        if (currentSceneName != "MenuScene" && currentSceneName != "Game finished")
        {


            if (GameObject.FindGameObjectsWithTag("Coin").Length == 0 && Coin.playerScore > 0)
                congratulations();
        }
    }   
    void congratulations()
    {
        coinsCollected.SetActive(true);
        Invoke("LoadNextLevel", 1);
    }

    
    public void LoadNextLevel()
    {      
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }
    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }
}
