using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeleteBalls : MonoBehaviour
{
    private int points;
    [SerializeField] private int ballsLeft;
    private int ballsToDelete;
    [SerializeField] private TextMeshProUGUI ballsGUI;
    private void Awake()
    {
        points = 0;
        ballsToDelete = ballsLeft;
        ballsGUI.text = ballsLeft.ToString();
    }

    private void Update()
    {
        if (points == ballsToDelete)
        {
            SceneManager.LoadScene("Win");
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
