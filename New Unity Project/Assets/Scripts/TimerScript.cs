using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    public TMP_Text timerText;

    private float startTime;
    private string minutes;
    private string seconds;

    private bool finished = false;

    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("escape")){
            SceneManager.LoadScene(0);
        }
        if(finished)
            return;

        float t = Time.time - startTime;

        minutes = ((int) t/60).ToString();
        seconds = (t % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;
    }

    public void Finish()
    {
        finished = true;
        timerText.color = Color.red;
    }
}
