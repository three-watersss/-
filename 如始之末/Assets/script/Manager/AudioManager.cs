using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    private AudioSource bgmSource;//≤•∑≈bgmµƒ“Ù∆µ
    private void Awake()
    {
        Instance = this;
    }
    //≥ı ºªØ
    public void Init()
    {
        gameObject.AddComponent<AudioSource>();
    }

    //≤•∑≈bgm
    public void PlayBGM(string name,bool isLoop=true)
    {
        //º”‘ÿbgm…˘“ÙºÙº≠
        AudioClip clip=Resources.Load<AudioClip>("Sounds/BGM/" + name);

        bgmSource.clip = clip;//…Ë÷√“Ù∆µ

        bgmSource.loop = isLoop;

        bgmSource.Play();
    
    }

    //≤•∑≈“Ù∆µ
    public void PlayEffect(string name)
    {
        AudioClip clip = Resources.Load<AudioClip>("Sounds/" + name);
        AudioSource.PlayClipAtPoint(clip, transform.position);//≤•∑≈
    }
}
