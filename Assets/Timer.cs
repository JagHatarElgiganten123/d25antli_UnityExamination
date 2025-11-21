using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float timer;
    [SerializeField] private TextMeshProUGUI timerGUI;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = 10;
        timerGUI.text = timer.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime;
        timerGUI.text = timer.ToString();
    }
}
