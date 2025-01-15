using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class NewBehaviourScript : MonoBehaviour
{
    public AudioMixer Audio;
    public void SetVolume (float volume)
    {
        Audio.SetFloat("volume", -81);
    }
}
