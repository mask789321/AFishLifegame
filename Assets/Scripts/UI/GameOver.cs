using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] GameObject GameOverScreen;
    //[SerializeField] GameObject GameWinScreen;
    //[SerializeField] GameObject CreditPanel;


    private void Start()
    {
        GameOverScreen.SetActive(false);
    }

    private void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Tab))
        {
            test();
            CreditPanel.SetActive(false);
        }*/
    }

    void test()
    {
        //GameWinScreen.SetActive(true);
        UnityEngine.Cursor.lockState = CursorLockMode.None;
        UnityEngine.Cursor.visible = true;
        Time.timeScale = 0;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Start Screen");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quitting Game");
    }
    
}
