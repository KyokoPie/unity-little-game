using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class touch : MonoBehaviour

    
{
    private int foodcount = 0;
    public AudioSource foodm;
    public Text showtext;
    public AudioClip one;
    public AudioClip two;
    public AudioClip three;
    public AudioClip four;
    public AudioClip five;
    public AudioClip six;
    public AudioClip seven;
    public AudioClip eight;
    public AudioClip nine;

    public GameObject GG;
    public AudioClip ggVo;

    public Animator gg;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        showtext.text = "到處蒐集食物吧!";

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Delete))
        {
            Debug.Log("HI");
            foodcount = 8;
        }


    }
    private void OnCollisionEnter(Collision food)
    {

            if (food.gameObject.tag == "food")
        {
            foodcount++;
            Destroy(food.gameObject);

            if (foodcount  == 1)
            {
                foodm.PlayOneShot(one);
                
            }
            if (foodcount == 2)
            {
                foodm.PlayOneShot(two);

            }
            if (foodcount == 3)
            {
                foodm.PlayOneShot(three);

            }
            if (foodcount == 4)
            {
                foodm.PlayOneShot(four);

            }
            if (foodcount == 5)
            {
                foodm.PlayOneShot(five);

            }
            if (foodcount == 6)
            {
                foodm.PlayOneShot(six);

            }
            if (foodcount == 7)
            {
                foodm.PlayOneShot(seven);

            }
            if (foodcount == 8)
            {
                foodm.PlayOneShot(eight);

            }
            if (foodcount == 9)
            {
                GG.SetActive(true);

                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                gg.SetBool("goodgame", true);

                foodm.PlayOneShot(ggVo);




            }
            showtext.text = "目前獲得食物:" + foodcount.ToString() +"/9";
        }
       
        
    }


}
