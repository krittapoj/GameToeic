using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountTime : MonoBehaviour
{
    public Text Timetext;

    public float gameTime;

    private bool stopTimer;

   
    void Start()
    {
        stopTimer = false;
    }

  
    void Update()
    {
        float time = gameTime - Time.time;

        int mintes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time - mintes * 60f);

        string textTime = string.Format("{0:0}:{1:00}", mintes, seconds);

        if (time <= 0)
        {
            //SceneManager.LoadScene("GameOver");
            stopTimer = true;
        }

        if (stopTimer == false)
        {
            
            Timetext.text = textTime;
        }
    }
}
