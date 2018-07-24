using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// this goes on the object to be hit
/// broken version is the same object but moddeld in pecies to break
/// </summary>
public class Shatter : MonoBehaviour
{
    public GameObject BrokenVersion;
    public Transition transition;

    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Break();
            audioSource.Play();
        }
    }

    public void Break()
    {
        GameObject copy = Instantiate(BrokenVersion, transform.position, transform.rotation);
        Destroy(gameObject);
        Destroy(copy, 5);
    }

    private void OnMouseDown()
    {
        Break();
        if(transition != null)
        transition.animator.SetTrigger("FadeIn");
    }
}
