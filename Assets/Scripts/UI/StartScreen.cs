using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    //public GameObject GameOverScreen;
    public GameObject CreditsScreen;
    public GameObject startMenu;

    public void Start()
    {
        Time.timeScale = 0f;
        //GameOverScreen.SetActive(false);
    }

    public void GameStart()
    {
        SceneManager.LoadScene("Level");
        SoundManager.Instance.musicSource.Stop();
        SoundManager.Instance.PlayMusic("Ambience");
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
        CreditsScreen.SetActive(false);
        startMenu.SetActive(true);
        //SceneManager.LoadScene("StartScreen");
    }

    public void ToCredits()
    {
        Time.timeScale = 1f;
        CreditsScreen.SetActive(true);
        startMenu.SetActive(false);    
        //SceneManager.LoadScene("CreditsScreen");
    }
}
