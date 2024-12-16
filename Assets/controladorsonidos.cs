using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorsonidos : MonoBehaviour
{
    public static controladorsonidos instance;
    private AudioSource AudioSource;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        AudioSource = GetComponent<AudioSource>();

    }
    public void ejecutarsonido(AudioClip sonido)
    {
        AudioSource.clip = sonido;
        AudioSource.Play();
    }
    
}