using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puase : MonoBehaviour {

    bool paused;
    public GameObject menu;

	// Use this for initialization
	void Start ()
    {
        paused = false;
        menu.SetActive(false);
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKeyDown("escape") && paused == false)
        {
            paused = true;
            menu.SetActive(true);
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        if (Input.GetKeyDown("escape") && paused == true)
            resume();
    }

    public void resume()
    {
        paused = false;
        menu.SetActive(false);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
