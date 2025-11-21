using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeleteBalls : MonoBehaviour
{
    private int points;

    private void Awake()
    {
        points = 0;
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
        }
    }
}
