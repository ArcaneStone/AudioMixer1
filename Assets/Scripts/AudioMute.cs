using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioMute : MonoBehaviour
{
    [SerializeField] private Toggle _muteToggle;
    [SerializeField] private AudioMixer _audioMixer;

    [SerializeField] private string exposedParameterName = "Master";

    private void OnEnable()
    {
        _muteToggle.onValueChanged.AddListener(ToggleAudio);
    }

    private void OnDisable()
    {
        _muteToggle.onValueChanged.RemoveListener(ToggleAudio);
    }

    private void ToggleAudio(bool isMuted)
    {
        float minValue = -80f;
        float maxValue = 0f;

        _audioMixer.SetFloat(exposedParameterName, isMuted ? minValue : maxValue);
    }
}

