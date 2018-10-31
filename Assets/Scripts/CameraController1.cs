using UnityEngine;
using System.Collections;

public class CameraController1 : MonoBehaviour {
    public AudioClip SoundClip; private AudioSource SoundSource;
    void Start()
    {
        SoundSource.clip = SoundClip; SoundSource.Play();



    }
    void Awake()
    {

        DontDestroyOnLoad(gameObject);
        SoundSource = gameObject.AddComponent<AudioSource>();
        SoundSource.GetComponent<AudioSource>().volume = 0.8f;
    }
}
