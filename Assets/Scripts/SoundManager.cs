using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class SoundManager : MonoBehaviour
{   
    //reference to access anywhere
    public static SoundManager Instance;

    public AudioSrc[] music, sfx;
    public AudioSource musicSource, sfxSource;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        //PlayMusic("Acceptance");
    }

    //finds and plays music track
    public void PlayMusic(string name)
    {
        AudioSrc s = Array.Find(music, x => x.name == name);

        if (s == null)
        {
            Debug.Log("Music not found.");
        }

        else
        {
            musicSource.clip = s.clip;
            musicSource.Play();
        }

    }

    //finds and plays sound effects
    public void PlaySFX(string name)
    {
        AudioSrc s = Array.Find(sfx, x => x.name == name);

        if (s == null)
        {
            Debug.Log("Sound not found.");
        }

        else
        {
            sfxSource.PlayOneShot(s.clip);
        }

    }

}
