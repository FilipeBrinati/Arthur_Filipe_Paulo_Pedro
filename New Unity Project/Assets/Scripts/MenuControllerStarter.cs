using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControllerStarter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Level", 0);
        PlayerPrefs.SetFloat("Time", -1);
        PlayerPrefs.SetInt("Mode", 0);
    }

    // Update is called once per frame
    void Update()
    {
        SceneManager.LoadScene("MenuStart");
    }
}
