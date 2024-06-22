using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class audio : MonoBehaviour
{
    public AudioSource audioSource; // Reference to the AudioSource component
    public Slider volumeSlider; // Reference to the UI Slider for volume control
    public Toggle muteToggle; // Reference to the UI Toggle for mute control

    private float previousVolume; // To store the volume before muting

    void Start()
    {
        // Load the saved volume and mute settings
        if (PlayerPrefs.HasKey("Volume"))
        {
            audioSource.volume = PlayerPrefs.GetFloat("Volume");
        }

        if (PlayerPrefs.HasKey("Muted"))
        {
            audioSource.mute = PlayerPrefs.GetInt("Muted") == 1;
        }

        // Set the slider's value to the audioSource's volume
        volumeSlider.value = audioSource.volume;

        // Initialize the mute toggle
        muteToggle.isOn = audioSource.mute;

        // Add listeners to handle value changes
        volumeSlider.onValueChanged.AddListener(SetVolume);
        muteToggle.onValueChanged.AddListener(ToggleMute);
    }

    // Method to set the volume
    public void SetVolume(float volume)
    {
        if (muteToggle.isOn)
        {
            // If muted, store the new volume but do not apply it
            previousVolume = volume;
        }
        else
        {
            // Apply the volume change
            audioSource.volume = volume;
            // Save the volume setting
            PlayerPrefs.SetFloat("Volume", volume);
            PlayerPrefs.Save();
        }
    }

    // Method to toggle mute
    public void ToggleMute(bool isMuted)
    {
        if (isMuted)
        {
            // Store the current volume before muting
            previousVolume = audioSource.volume;
            // Mute the audio
            audioSource.volume = 0;
            audioSource.mute = true;
        }
        else
        {
            // Unmute the audio and restore the previous volume
            audioSource.mute = false;
            audioSource.volume = previousVolume;
        }

        // Save the mute setting
        PlayerPrefs.SetInt("Muted", isMuted ? 1 : 0);
        PlayerPrefs.Save();
    }
}
