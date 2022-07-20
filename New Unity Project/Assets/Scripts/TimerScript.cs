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

    private bool checkpoint = false;
    private bool finished = false;

    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;
        if(Input.GetKeyDown("escape")){
            SceneManager.LoadScene(0);
        }
        if(finished){
            return;
        }
        if(checkpoint){
            timerText.color = Color.red;
            StartCoroutine(Wait());
            timerText.color = Color.white;
            checkpoint = false;
        }

        minutes = ((int) t/60).ToString();
        seconds = (t % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;
    }

    public void Finish()
    {
        finished = true;
        timerText.color = Color.red;
    }

    public void Continue()
    {
        int aux = (PlayerPrefs.GetInt("Checkpoint")) + 1;
        finished = true;

        checkpoint = true;

        finished = false;
        PlayerPrefs.SetInt("Checkpoint", aux);
    }

    IEnumerator Wait(){
        yield return new WaitForSecondsRealtime(2);
    }
}
