using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour {

    public GameObject quit;
    public GameObject start;

    public GameObject music;

    public Animator animator;


    public void fadeDone()
    {
        if (start == null)
        {
            DontDestroyOnLoad(music);
            SceneManager.LoadScene("Test");
        }

        else if (quit == null)
            Application.Quit();
    }

    public void Quit()
    {
        Application.Quit();
    }
}
