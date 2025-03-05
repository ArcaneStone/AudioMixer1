using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] private Slider _volumeSlider;
    [SerializeField] private AudioMixer _audioMixer;
    [SerializeField] private string _exposedParameterName;

    private void OnEnable()
    {
        _volumeSlider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    private void OnDisable()
    {
        _volumeSlider.onValueChanged.RemoveListener(OnSliderValueChanged);
    }

    private void Start()
    {
        float currentVolume = 0f;
        float minValue = -80f;
        float maxValue = 0f;

        _audioMixer.GetFloat(_exposedParameterName, out currentVolume);
        _volumeSlider.value = Mathf.InverseLerp(minValue, maxValue, currentVolume);
    }

    private void OnSliderValueChanged(float value)
    {
        float minValue = 0.0001f;
        float factor = 20f;

        if(value <= 0)
        {
            value = minValue;
        }

        float volume = Mathf.Log10(value) * factor;

        _audioMixer.SetFloat(_exposedParameterName, volume);
    }
}
