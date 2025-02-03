using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class soundEffects : MonoBehaviour
{
    AudioSource audio;
    SpriteRenderer sr; 

    public AudioClip[] audioClips;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
       Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (sr.bounds.Contains(mousePos))
        {
            int randomNumber = Random.Range(0, audioClips.Length);
            if (!audio.isPlaying)
            {
                audio.Play();
                audio.PlayOneShot(audioClips[randomNumber]);
            }
        }

    }


}
