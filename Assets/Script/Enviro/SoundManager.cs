using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip clickSound;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) || (Input.GetKey(KeyCode.E)))
        {
            PlayClickSound();
        }
    }

    private void PlayClickSound()
    {
        audioSource.PlayOneShot(clickSound);
    }
}
