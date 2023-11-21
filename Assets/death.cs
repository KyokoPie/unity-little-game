using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{

    private Vector3 startPos;
    private Quaternion starRot;
    public Animator gg;
    public AudioSource foodm;
    public AudioClip nine;
    public GameObject GG;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        starRot = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.tag == "death")
        {
            foodm.PlayOneShot(nine);
            GG.SetActive(true);

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            gg.SetBool("goodgame", true);

        }
    }
}
