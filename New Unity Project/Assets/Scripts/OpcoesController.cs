using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

public class OpcoesController : MonoBehaviour
{
    public AudioMixer audioMixer;
    public TMP_Dropdown resolutionDropdown;

    Resolution[] resolutions;

    void Start() {
        resolutions = Screen.resolutions;
        List<string> options = new List<string>();

        resolutionDropdown.ClearOptions();

        int currResolution = resolutions.Length - 1;
        for(int i = 0; i < resolutions.Length; i++) {
            string opt = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(opt);
                
            if(resolutions[i].width == Screen.currentResolution.width && 
               resolutions[i].height == Screen.currentResolution.height)
                currResolution = i;
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currResolution;
        resolutionDropdown.RefreshShownValue();
    }

    public void SetResolution(int index) {
        Resolution resol = resolutions[index];
        Screen.SetResolution(resol.width, resol.height, true);
    }

    public void SetVolume(float volume){
        audioMixer.SetFloat("volume", volume);
    }

   public void Voltar(){
        SceneManager.LoadScene("MenuStart");
    }
}
