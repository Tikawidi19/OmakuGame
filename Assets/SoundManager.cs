using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    public AudioSource backgroundMusic;
    public AudioSource soundEffects;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetMusicVolume(float volume)
    {
        backgroundMusic.volume = volume;
        PlayerPrefs.SetFloat("MusicVolume", volume);
    }

    public void SetSoundEffectsVolume(float volume)
    {
        soundEffects.volume = volume;
        PlayerPrefs.SetFloat("SoundEffectsVolume", volume);
    }

    private void Start()
    {
        if (PlayerPrefs.HasKey("MusicVolume"))
        {
            backgroundMusic.volume = PlayerPrefs.GetFloat("MusicVolume");
        }

        if (PlayerPrefs.HasKey("SoundEffectsVolume"))
        {
            soundEffects.volume = PlayerPrefs.GetFloat("SoundEffectsVolume");
        }
    }
}
