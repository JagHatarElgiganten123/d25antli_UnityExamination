using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartAndExit : MonoBehaviour
{
    [SerializeField] private string sceneName;
    
    public void StartGame()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
