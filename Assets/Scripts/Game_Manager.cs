using UnityEngine;
using System.Collections;

public class Game_Manager : MonoBehaviour
{
    private bool Paused;
    public GameObject PauseTitle;
    public GameObject ResumeButton;
    public GameObject RestartButton;
    public GameObject QuitButton;

	void Start ()
    {
        Time.timeScale = 1.0f;
        Paused = false;
	}
	
	void Update ()
    {
	    
	}

    public void Pause ()
    {
        Paused = !Paused;

        if (!Paused)
        {
            Time.timeScale = 1.0f;

            PauseTitle.SetActive(false);
            ResumeButton.SetActive(false);
            RestartButton.SetActive(false);
            QuitButton.SetActive(false);
        }

        if(Paused)
        {
            Time.timeScale = 0.0f;

            PauseTitle.SetActive(true);
            ResumeButton.SetActive(true);
            RestartButton.SetActive(true);
            QuitButton.SetActive(true);
        }
    }
}
