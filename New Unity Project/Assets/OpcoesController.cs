using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class OpcoesController : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void volumeHandler(float volume){
        audioMixer.SetFloat("volume", volume);
    }

   public void Voltar(){
        SceneManager.LoadScene("MenuStart");
    }
}
