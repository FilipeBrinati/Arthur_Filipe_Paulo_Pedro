using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ModeScript : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public DataManager dataManager;

    private List<float> list1 = new List<float>();
    private List<float> list2 = new List<float>();
    private List<float> list3 = new List<float>();

    private void Start(){

        dataManager.Load();
        int level = PlayerPrefs.GetInt("Level");
        float time = PlayerPrefs.GetFloat("Time");
        int mode = PlayerPrefs.GetInt("Mode");

        list1 = dataManager.data.time_1;
        list2 = dataManager.data.time_2;
        list3 = dataManager.data.time_3;

        if(mode == 0){
            switch(level){
                case 1: 
                    list1.Add(time);
                    PlayerPrefs.SetInt("Level", 0);
                    break;
                case 2:
                    list2.Add(time);
                    PlayerPrefs.SetInt("Level", 0);
                    break;
                case 3:
                    list3.Add(time);
                    PlayerPrefs.SetInt("Level", 0);
                    break;
            }
        }
        list1.Sort();
        list2.Sort();
        list3.Sort();

        dataManager.data.time_1 = list1;
        dataManager.data.time_2 = list2;
        dataManager.data.time_3 = list3;

        dataManager.Save();
    }
    

    public void loadFirstLevel(){
        dataManager.Save();
        string text = "Melhores tempos:" + "\n";
        for(int i = 0, j = 1; i < list1.Count && j <= 10; i++, j++){
            string aux = list1[i].ToString();
            string position = i.ToString();
            text = text + position + ":" + aux + "\n";
        }
        textDisplay.text = text;
    }
    public void loadSecondLevel(){
        dataManager.Save();
        string text = "Melhores tempos:" + "\n";
        for(int i = 0, j = 1; i < list2.Count && j <= 10; i++, j++){
            string aux = list2[i].ToString();
            string position = i.ToString();
            text = text + position + ":" + aux + "\n";
        }
        textDisplay.text = text;
    }
    public void loadThirdLevel(){
        dataManager.Save();
        string text = "Melhores tempos:" + "\n";
        for(int i = 0, j = 1; i < list3.Count && j <= 10; i++, j++){
            string aux = list3[i].ToString();
            string position = i.ToString();
            text = text + position + ":" + aux + "\n";
        }
        textDisplay.text = text;
    }
    
    public void PlayComp(){
        SceneManager.LoadScene("CompMode");
    }

    public void PlayCompLevel1(){
        PlayerPrefs.SetInt("Mode", 0);
        PlayerPrefs.SetInt("Level", 1);
        SceneManager.LoadScene("Level 1");
    }

    public void PlayCompLevel2(){
        PlayerPrefs.SetInt("Mode", 0);
        PlayerPrefs.SetInt("Level", 2);
        SceneManager.LoadScene("Level 2");
    }

    public void PlayCompLevel3(){
        PlayerPrefs.SetInt("Mode", 0);
        PlayerPrefs.SetInt("Level", 3);
        SceneManager.LoadScene("Level 3");
    }

    public void PlayPratLevel1(){
        PlayerPrefs.SetInt("Mode", 1);
        SceneManager.LoadScene("Level 1");
    }

    public void PlayPratLevel2(){
        PlayerPrefs.SetInt("Mode", 1);
        SceneManager.LoadScene("Level 2");
    }

    public void PlayPratLevel3(){
        PlayerPrefs.SetInt("Mode", 1);
        SceneManager.LoadScene("Level 3");
    }

    public void PlayPrat(){
        SceneManager.LoadScene("PratMode");
    }

    public void Voltar(){
        SceneManager.LoadScene("MenuStart");
    }

    public void ModeVoltar(){
        SceneManager.LoadScene("SelecaoModo");
    }
    public void PlayCompTestTree(){
        SceneManager.LoadScene("telaarthur");
    }
}
