using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class PlayControl : MonoBehaviour
{
    public AudioSource AudioSource;
    public Text VolumeText;
    public Slider Slider;

    private void Start()
    {
        Slider.value = PlayerPrefs.GetFloat("Volume", 0.5f);
    }


    private void Update()
    {
        VolumeText.text = $"{Slider.value * 100:0}";
    }

    public void OnVolumeSliderValueChanged(Slider slider)
    {
        ///0.0 to 1.0
        var volume = Mathf.Clamp01(slider.value);
        ///��������
        AudioSource.volume = volume;
        ///��������ֵ
        PlayerPrefs.SetFloat("Volume", volume);
    }
}
