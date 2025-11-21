using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartAndExit : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
