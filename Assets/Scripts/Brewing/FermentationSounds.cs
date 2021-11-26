using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FermentationSounds : MonoBehaviour
{

    [SerializeField] AudioSource bubblingSound;
    private bool bubbling = true;
    private int wait;
    private float pitch;

    private void OnEnable()
    {
        bubblingSound = this.GetComponent<AudioSource>();
        StartCoroutine("MakeBubblingSounds");
    }


    private IEnumerator MakeBubblingSounds()
    {
        while (bubbling)
        {
            wait = Random.Range(3, 8);
            pitch = Random.Range(0.75f, 1.25f);
            bubblingSound.pitch = pitch; 
            yield return new WaitForSeconds(wait);
            bubblingSound.PlayOneShot(bubblingSound.clip, 1);
        }


    }



}
