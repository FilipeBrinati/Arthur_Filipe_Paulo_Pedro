using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuStartScript : MonoBehaviour
{

    public void PlayGame(){
        SceneManager.LoadScene("SelecaoModo");
    }

    public void QuitGame(){
        Application.Quit();
    }

    public void Options(){
        SceneManager.LoadScene("SelecaoModo");
        //mudar com a cena q o Paulo ta fazendo
    }

}
