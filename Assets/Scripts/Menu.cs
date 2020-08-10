using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject pauseUI;
    //private bool gamePaused;
    // Start is called before the first frame update
    void Start()
    {
        pauseUI.SetActive(false);
        //gamePaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Esc Pressed!");
            if(pauseUI.activeSelf)
                Resume();
            else
                Pause();
        }
    }

    public void Resume()
    {
        Debug.Log("Resume Function");
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
        //gamePaused = false;
    }
    
    private void Pause()
    {
        Debug.Log("Pause Function");
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
        //gamePaused = true;
    }

    public void QuitGame()
    {
        Debug.Log("QuitGame");
        Application.Quit();
    }
}
