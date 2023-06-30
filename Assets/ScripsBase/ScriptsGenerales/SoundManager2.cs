using UnityEngine.Audio;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager2 : MonoBehaviour
{
    public Sound[] sounds;
    public static SoundManager2 instance;

    void Awake()
    {
        if (instance == null)
            instance = this;

        else
        {

            Destroy(gameObject);
            return;
        }




        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }

    }
    void Start()
    {

        string actualSceneName = SceneManager.GetActiveScene().name;


        if (actualSceneName == "SampleScene")
        {
            Play("Rivers");
        }
    
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound :" + name + "not found dude!");
            return;
        }
        s.source.Play();
    }

}

