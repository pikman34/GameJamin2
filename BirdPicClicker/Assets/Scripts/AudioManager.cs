using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    public AudioClip background;
    public AudioClip pageTurn;
    public AudioClip purchase;
    public AudioClip buttonClick;
    public AudioClip swanNoise;
    public AudioClip bluetitNoise;
    public AudioClip doveNoise;
    public AudioClip robinNoise;
    public AudioClip rookNoise;
    public AudioClip goldfinchNoise;


    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

    public void PLAYSFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}

