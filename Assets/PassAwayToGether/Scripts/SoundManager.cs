using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    [SerializeField] private Sound[] sounds;
    [Serializable] 
    public struct Sound
    {
        public SoundName soundName;
        public AudioClip clip;
        [Range(0f,1f)]public float volume;
        public bool loop;
        [HideInInspector] public AudioSource audioSource;
    }
    public enum SoundName
    {
        BGM,
        Win,
        Lose,
        hit,
        walk,
        
        

    }
    public void Play(SoundName soundName)
    {
        Sound sound = GetSound(soundName);
        if (sound.audioSource == null)
        {
            sound.audioSource = gameObject.AddComponent<AudioSource>();
        }

        sound.audioSource.clip = sound.clip;
        sound.audioSource.volume = sound.volume;
        sound.audioSource.loop = sound.loop;
        sound.audioSource.Play();
        
    }

    private Sound GetSound(SoundName soundName)
    {
        return Array.Find(sounds, s => s.soundName == soundName);
    }
}