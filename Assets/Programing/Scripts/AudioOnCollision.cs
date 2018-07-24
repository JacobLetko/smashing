using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AudioOnCollision : MonoBehaviour
{
    public AudioClip squeak;
    AudioSource audioSource;

    public int counter;
    public TextMeshProUGUI score;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = squeak;
        counter = 0;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 8)
            counter++;

        if (!audioSource.isPlaying)
        audioSource.Play();
        //audioSource.loop = false;

        score.text = "Score: " + counter.ToString();
    }
}
