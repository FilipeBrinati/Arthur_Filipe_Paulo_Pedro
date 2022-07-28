using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public int order = 1;
    public int last = 0;
    public GameObject cylinderLeft;
    public GameObject cylinderRight;
    public GameObject post;

    private Renderer ml;
    private Renderer mr;
    private Renderer mp;

    private void Start(){
        ml = cylinderLeft.GetComponent<Renderer>();
        mr = cylinderRight.GetComponent<Renderer>();
        mp = post.GetComponent<Renderer>();
    }
    // Start is called before the first frame update
    private void Update(){
        if(order == PlayerPrefs.GetInt("Checkpoint") && PlayerPrefs.GetInt("Mode") == 1){
            ml.material.color = new Color(1f, 0f, 0f, 1f);
            mr.material.color = new Color(1f, 0f, 0f, 1f);
            mp.material.color = new Color(1f, 0f, 0f, 1f);
        }   
        else{
            ml.material.color = new Color(1f, 1f, 1f, 1f);
            mr.material.color = new Color(1f, 1f, 1f, 1f);
            mp.material.color = new Color(1f, 1f, 1f, 1f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(PlayerPrefs.GetInt("Checkpoint") == last){
            GameObject.Find("Controller").SendMessage("Finish");
        }
        else if(order == PlayerPrefs.GetInt("Checkpoint")) {
            GameObject.Find("Controller").SendMessage("Continue");
        }
        
    }
}
