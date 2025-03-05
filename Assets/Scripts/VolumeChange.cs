using UnityEngine;
using UnityEngine.Audio;

public class VolumeChange : MonoBehaviour
{
    [SerializeField] private VolumeSlider masterVolumeSlider;
    [SerializeField] private VolumeSlider musicVolumeSlider;
    [SerializeField] private VolumeSlider effectsVolumeSlider;

    [SerializeField] private AudioMixer audioMixer;

    private void Start()
    {
        masterVolumeSlider.Init(audioMixer, "Master");
        musicVolumeSlider.Init(audioMixer, "Music");
        effectsVolumeSlider.Init(audioMixer, "Effects");
    }
}

