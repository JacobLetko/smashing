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

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(BrokenVersion, transform.position, transform.rotation);
        Destroy(gameObject);
        Destroy(BrokenVersion, 2);
    }
}
