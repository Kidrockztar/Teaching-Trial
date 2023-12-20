using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerDisplay;
    public TextMeshProUGUI fastestTime;
    public TextMeshProUGUI secondFastest;     
    public TextMeshProUGUI thirdFastest;  

    private List<string> times = new List<string>();
    private float startTime;
    private float time;
    public bool timerRunning;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timerRunning)
        {
            timerDisplay.text = (Time.time - startTime).ToString("0.00");
        }
    }

    public void StartTimer()
    {
        timerRunning = true;
        startTime = Time.time;
    }

    public void StopTimer()
    {
        timerRunning = false;
        times.Add(timerDisplay.text);

        times.Sort();
        if(times.Count == 1)
        {
            fastestTime.text = times[0];
        }
        if(times.Count== 2)
        {
            fastestTime.text = times[0];
            secondFastest.text = times[1];
        }
        if (times.Count >= 3)
        {
            fastestTime.text = times[0];
            secondFastest.text = times[1];
            thirdFastest.text = times[2];
        }
        
    }
}
