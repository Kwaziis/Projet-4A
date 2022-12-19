using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI timerText;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        Initialize();
        updateTimerDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        updateTimerDisplay();
    }

    void Initialize()
    {
        time = 0;
    }

    void updateTimerDisplay() 
    {
        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);
        string currentTime = string.Format("{00:00}{1:00}", minutes, seconds);
        currentTime = currentTime.Insert(2, ":");
        timerText.text = currentTime;
    }
}
