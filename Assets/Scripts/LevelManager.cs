using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public string WinnersScreen;
    public string mainMenu;
    public string MainGameScene;
    public string LoosersScreen;
    public PlayerHealth playerHealth;
    public int health;
    public float currentTime = 0;
    public float totalTime = 10;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        exitScene();
        YouWonScene();
    }

    public void changeScene()
    {
        SceneManager.LoadScene(MainGameScene);
    }

    public void restartGame()
    {
        SceneManager.LoadScene(MainGameScene);
    }
    
    public void quitGame()
    {
        Application.Quit();
    }

    public void MainMenuScene()
    {
        SceneManager.LoadScene(mainMenu);
    }
    public void exitScene()
    {
        health = playerHealth.currentHealth;
        if (health < 1)
        {

            SceneManager.LoadScene(LoosersScreen);
        }
    }

    public void YouWonScene()
    {
        currentTime += 1 * Time.deltaTime;
        if (currentTime > totalTime)
        {
            SceneManager.LoadScene(WinnersScreen);
        }
    }
}
