using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeControl : MonoBehaviour
{
    private AudioSource audioSource;
    private float volume = 1f;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        audioSource.volume = volume;
    }

    public void SetVolume(float vol) 
    {
        volume = vol;
    }
}
