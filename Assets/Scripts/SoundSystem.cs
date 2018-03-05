using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSystem : MonoBehaviour
{

    public static SoundSystem instance;

    public AudioSource audioCoin;
    public AudioSource audioFlap;
    public AudioSource audioHit;

    private void Awake()
    {
        if (SoundSystem.instance == null)
        {
            SoundSystem.instance = this;

        }
        else if (SoundSystem.instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void PlayCoin()
    {
        audioCoin.Play();
    }

    public void PlayFlap()
    {
        audioFlap.Play();
    }

    public void PlayHit()
    {
        audioHit.Play();
    }

    private void OnDestroy()
    {
        if (SoundSystem.instance == this)
        {
            SoundSystem.instance = null;
        }
    }

}
