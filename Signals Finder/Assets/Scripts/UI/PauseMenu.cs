using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;

    public GameObject pausedMenuUI;
    public GameObject resetMenuUI;
    public GameObject settingMenuUI;
    public GameObject quitMenuUI;
    public GameObject GameOverUI;

    public SignalScript signalScript;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    //<SUMMARY>
    //Pause Menu Controller
    //<SUMMARY>

    public void Resume()
    {
        pausedMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    public void Pause()
    {
        pausedMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    //<SUMMARY>
    //Reset Menu Controller
    //<SUMMARY>
    public void PauseReset()
    {
        pausedMenuUI.SetActive(false);
        GameOverUI.SetActive(false);
        resetMenuUI.SetActive(true);
        signalScript.enabled = false;
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void ResumeReset()
    {
        pausedMenuUI.SetActive(true);
        resetMenuUI.SetActive(false);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void ResetLevel1()
    {
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1f;
    }
    public void ResetLevel2()
    {
        //TODO Reset Level
        SceneManager.LoadScene("Level2");
        Time.timeScale = 1f;
    }
    public void ResetLevel3()
    {
        //TODO Reset Level
        SceneManager.LoadScene("Level3");
        Time.timeScale = 1f;
    }
    public void ResetLevel4()
    {
        //TODO Reset Level
        SceneManager.LoadScene("Level4");
        Time.timeScale = 1f;
    }
    public void ResetLevel5()
    {
        //TODO Reset Level
        SceneManager.LoadScene("Level5");
        Time.timeScale = 1f;
    }

    //<SUMMARY>
    //Setting Menu Controller
    //<SUMMARY>
    public void PauseSetting()
    {
        pausedMenuUI.SetActive(false);
        settingMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }
    public void ResumeSetting()
    {
        pausedMenuUI.SetActive(true);
        settingMenuUI.SetActive(false);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    //<SUMMARY>
    //Quit Menu Controller
    //<SUMMARY>
    public void PauseQuit()
    {
        pausedMenuUI.SetActive(false);
        quitMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }
    public void ResumeQuit()
    {
        pausedMenuUI.SetActive(true);
        quitMenuUI.SetActive(false);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }
    public void Quit()
    {
        //Application.Quit();
    }

    public void BackToTitle()
    {
        SceneManager.LoadScene("Title_Screen");
    }
}
