using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ModeScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayComp(){
        SceneManager.LoadScene("CompMode");
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
