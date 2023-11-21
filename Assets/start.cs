using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour

{

    public AudioSource startVo;

    public AudioClip Startvoice;
    public GameObject Panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void startbt()
    {
        SceneManager.LoadScene("Level01");
        startVo.PlayOneShot(Startvoice);
    }
    public void exit()
    {

        Debug.Log("exit");
        Application.Quit();
    }
    public void howPlay()
    {

        Debug.Log("play");
        Panel.SetActive(true);
        
    }
    public void howPlayClose()
    {

        Panel.SetActive(false);

    }
}
