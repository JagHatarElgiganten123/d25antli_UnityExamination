using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeleteBalls : MonoBehaviour
{
    private int points;
    [SerializeField] private int ballsLeft;
    [SerializeField] private TextMeshProUGUI ballsGUI;
    private void Awake()
    {
        points = 0;
        ballsGUI.text = ballsLeft.ToString();
    }

    private void Update()
    {
        if (points == 3)
        {
            SceneManager.LoadScene("Level 2");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Balls"))
        {
            Destroy(other.gameObject);
            points++;
            ballsLeft--;
            ballsGUI.text = ballsLeft.ToString();
        }
    }
}
