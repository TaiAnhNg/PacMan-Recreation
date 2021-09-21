using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class SoundControl : MonoBehaviour
{
    public AudioClip intro;
    public AudioClip gameplay;
    private AudioSource audiosource;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        StartCoroutine(playSound());
    }
    IEnumerator playSound()
    {
        audiosource.clip = intro;
        audiosource.Play();
        yield return new WaitForSeconds(audiosource.clip.length);
        audiosource.clip = gameplay;
        audiosource.Play();
        audiosource.loop = true;
    }
}

