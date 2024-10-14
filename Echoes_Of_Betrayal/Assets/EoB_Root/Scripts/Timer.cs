using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;   
    public float totalTime = 300f; 
    private float currentTime;

    void Start()
    {
        currentTime = totalTime; 
    }

    void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime; 
            UpdateTimerUI();
        }
        else
        {
            currentTime = 0;
            TimerEnded();
        }
    }

    void UpdateTimerUI()
    {
        // Formato de tiempo (minutos:segundos)
        int minutes = Mathf.FloorToInt(currentTime / 60);
        int seconds = Mathf.FloorToInt(currentTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void TimerEnded()
    {
        Debug.Log("¡El tiempo se ha acabado!");
        
    }
}
