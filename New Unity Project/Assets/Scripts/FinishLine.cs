using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public int order = 0;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(order == 0){
            GameObject.Find("Controller").SendMessage("Finish");
        }
        else if(order == PlayerPrefs.GetInt("Checkpoint")) {
            Debug.Log(PlayerPrefs.GetInt("Checkpoint"));
            GameObject.Find("Controller").SendMessage("Continue");
        }
        
    }
}
