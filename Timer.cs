using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    private bool finnished = false;
    
    
    void Start()
    {
        startTime = Time.time;
    }

   
    void Update()
    {
        if(finnished)
            return;

        float Timer = Time.time - startTime;

        string minutes = ((int) Timer / 60).ToString();
        string seconds = (Timer % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;
        
    }

    public void Finnish()
    {
        finnished = true;
        timerText.color = Color.yellow;
    }
}
