using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackGroundSoundTest : MonoBehaviour
{
    AudioSource Aud;

    void Start()
    {
        Aud = GetComponent<AudioSource>();
    }
    private void Update()
    {
        Aud.volume = SoundManager.BackGornudSound;
    }

    public void PlayButten()
    {
        if(SoundManager.Count == 0)
        {
            Aud.Play();
            SoundManager.Count++;
        }
        else
        {
            Aud.Stop();
            SoundManager.Count = 0;
        }
        
    }


}
