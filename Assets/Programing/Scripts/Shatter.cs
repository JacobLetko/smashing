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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject copy = Instantiate(BrokenVersion, transform.position, transform.rotation);
            Destroy(gameObject);
            Destroy(copy, 2);
        }
    }

    public void Break()
    {
        GameObject copy = Instantiate(BrokenVersion, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    private void OnMouseDown()
    {
        GetComponent<Shatter>().Break();
        if(transition != null)
        transition.animator.SetTrigger("FadeIn");
    }
}
