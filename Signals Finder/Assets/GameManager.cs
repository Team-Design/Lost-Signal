using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

    }

        public void LevelChooser()
    {
        SceneManager.LoadScene("LevelChooser");
    }

    public void Title()
    {
        SceneManager.LoadScene("Title_Screen");
    }

    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }
}
