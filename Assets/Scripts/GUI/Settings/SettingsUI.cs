using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
public class SettingsUI : MonoBehaviour
{
    public AudioMixer AudioMixer;
    public Slider MusicSlider;
    public Slider SFXSlider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        OnMusicVolChange();
        OnSFXVolChange();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMusicVolChange(){
        float NewVol = MusicSlider.value;
        if (NewVol <= 0.0f){
            NewVol = -80.0f;
        }
        else{
            NewVol = Mathf.Log10(NewVol);
            NewVol = NewVol * 20.0f;
        }
        AudioMixer.SetFloat("MusicVol", NewVol);
    }
    public void OnSFXVolChange(){
        float NewVol = SFXSlider.value;
        if (NewVol <= 0.0f){
            NewVol = -80.0f;
        }
        else{
            NewVol = Mathf.Log10(NewVol);
            NewVol = NewVol * 20.0f;
        }
        AudioMixer.SetFloat("SFXVol", NewVol);
    }
}
