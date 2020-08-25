using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip playerJump, playerCollect, gameMusic;
    static AudioSource audioSrc;

    private void Start()
    {
        playerJump = Resources.Load<AudioClip>("jump");
        playerCollect = Resources.Load<AudioClip>("collect");
        gameMusic = Resources.Load<AudioClip>("Level1Music");

        audioSrc = GetComponent<AudioSource>();
    }

    public static void PlaySound(string clip)
    {

        switch(clip)
        {
            case "jump":
                audioSrc.PlayOneShot(playerJump);
                break;
            case "collect":
                audioSrc.PlayOneShot(playerCollect);
                break;
            case "Level1Music":
                audioSrc.PlayOneShot(gameMusic);
                break;
        }
    }

}
