using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource music;


    public void setMusicVolume(float volume)
    {
        music.volume = volume;
    }
}