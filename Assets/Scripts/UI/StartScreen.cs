using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    public GameObject GameOverScreen;

    public void Start()
    {
        Time.timeScale = 0f;
        GameOverScreen.SetActive(false);
    }

    public void GameStart()
    {
        SceneManager.LoadScene("Level");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game ended.");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ToStart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("StartScreen");
    }


}
