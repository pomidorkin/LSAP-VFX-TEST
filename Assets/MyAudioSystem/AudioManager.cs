using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioMixer mixer;
    [SerializeField] AudioSource audioSourceMuted;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AnimationClip animationClip;
    // Start is called before the first frame update
    void Start()
    {
        mixer.SetFloat("MyExposedParam", -80.0f);
        //audioSource.PlayDelayed(animationClip.length);
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public AudioSource GetAudioSource()
    {
        return audioSourceMuted;
    }
}
