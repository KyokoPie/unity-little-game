using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour

    
{

    public static bool GameisPause = false;
    public GameObject Panel;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameisPause)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Panel.SetActive(false);
        Time.timeScale = 1f;
        GameisPause = false;

    }
    void Pause()
    {

        Panel.SetActive(true);
        Time.timeScale = 0f;
        GameisPause = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

    }

    public void exit()
    {

        Debug.Log("exit");
        Application.Quit();
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");

    }
}
