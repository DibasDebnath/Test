using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound
{

    public string audioClipName;
    public AudioClip audioClip;

    [Range(0, 1)]
    public float volume;

    [Range(.1f, 3f)]
    public float pitch;

    public bool isSound;
    public bool isMusic;
    public bool isLoop;

    [HideInInspector]
    public AudioSource audioSource;
}
