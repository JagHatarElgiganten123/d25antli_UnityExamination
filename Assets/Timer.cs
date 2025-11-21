using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] private int timer;
    [SerializeField] private TextMeshProUGUI timerGUI;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timerGUI.text = timer.ToString();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer = timer - 1;
        timerGUI.text = timer.ToString();

        if (timer <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
