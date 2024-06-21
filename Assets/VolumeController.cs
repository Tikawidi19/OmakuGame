using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeController : MonoBehaviour
{
    public void ChangeMusicVolume(float volume)
    {
        if (SoundManager.instance != null)
        {
            SoundManager.instance.SetMusicVolume(volume);
        }
    }

    public void ChangeSoundEffectsVolume(float volume)
    {
        if (SoundManager.instance != null)
        {
            SoundManager.instance.SetSoundEffectsVolume(volume);
        }
    }
}


