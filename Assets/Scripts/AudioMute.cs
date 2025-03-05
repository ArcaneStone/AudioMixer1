using UnityEngine;
using UnityEngine.UI;

public class AudioMute : MonoBehaviour
{
    [SerializeField] private AudioSource backgroundMusic;
    [SerializeField] private AudioSource soundEffect1;
    [SerializeField] private AudioSource soundEffect2;
    [SerializeField] private AudioSource soundEffect3;

    [SerializeField] private Toggle muteToggle;

    private void Start()
    {
        muteToggle.onValueChanged.AddListener(ToggleAllSounds);
    }

    private void ToggleAllSounds(bool isMuted)
    {
        backgroundMusic.mute = isMuted;
        soundEffect1.mute = isMuted;
        soundEffect2.mute = isMuted;
        soundEffect3.mute = isMuted;
    }
}
