using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SantaAudioManager : MonoBehaviour
{
    public static SantaAudioManager instance;

    [SerializeField] private AudioClip m_Jingles;
    [SerializeField] private AudioSource m_Hurt;

    private void Start()
    {
        instance = this;   
    }

    public void PlayHurtSound()
    {
        m_Hurt.Play();
    }
}
