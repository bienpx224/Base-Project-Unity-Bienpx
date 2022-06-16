using Hellmade.Sound;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Sounds : Singleton<Sounds>
{
    public static bool IgnorePopupShow = false;
    public static bool IgnorePopupClose = false;

    [Header("Music")]
    public AudioClip Music_Main;

    [Header("Sound")]

    public AudioClip Sfx_Show_Popup;
    public AudioClip Sfx_Hide_Popup;
    public AudioClip Sfx_Btn_Click;


    private void Start()
    {
        EazySoundManager.PlayMusic(Music_Main, 1, true, true);
    }

    Coroutine _coroutineSound;


    public void StopSound()
    {
        if (_coroutineSound != null)
        {
            StopCoroutine(_coroutineSound);
            _coroutineSound = null;
        }
    }
}
