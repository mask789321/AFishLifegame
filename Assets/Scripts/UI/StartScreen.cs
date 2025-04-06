using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    public void Start()
    {
        Time.timeScale = 0f;
    }

    public void GameStart()
    {
        SceneManager.LoadScene("Level");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("GET DA FUCK OUT");
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
