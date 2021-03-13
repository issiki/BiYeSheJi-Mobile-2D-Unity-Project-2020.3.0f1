using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class PlayControl : MonoBehaviour
{
    public AudioSource AudioSource;
    //public float Volume;
    public Text VolumeText;
    public Slider Slider;

    private void Start()
    {
        //Debug.Log($"which is null? slider? {Slider}");
        ///��ȡ������ֵ
        Slider.value = PlayerPrefs.GetFloat("Volume", 0.5f);
    }


    private void Update()
    {
        VolumeText.text = $"{Slider.value * 100:0}";
    }

    public void PlayOrPause()
    {
        if (AudioSource.isPlaying)
        {
            AudioSource.Pause();
            return;
        }

        AudioSource.Play();
    }

    /*
    public void Pause()
    {
        AudioSource.Pause();
    }
    */

    public void Stop()
    {
        AudioSource.Stop();
    }

    public void MuteOrUnmute()
    {
        var mute = AudioSource.mute;
        AudioSource.mute = !mute;
    }

    /*
    public void Mute()
    {
        AudioSource.mute = true;
    }

    public void Unmute()
    {
        AudioSource.mute = false;
    }
    */

    public void OnVolumeSliderValueChanged(Slider slider)
    {
        ///0.0 to 1.0
        var volume = Mathf.Clamp01(slider.value);
        ///��������
        AudioSource.volume = volume;
        ///��������ֵ
        PlayerPrefs.SetFloat("Volume", volume);
        ///��ʾ����ֵ������
        //VolumeText.text = $"{volume * 100:0}";
    }


    /*
    public void SetVolume(float volume)
    {
        ///0.0 to 1.0
        AudioSource.volume = volume;
    }

    public void SetVolumeText(Text text)
    {
        text.text = $"{AudioSource.volume * 100:0}";
    }

    public void SaveVolumeValue(Slider slider)
    {
        PlayerPrefs.SetFloat("Volume", Slider.value);
    }
    */

}
