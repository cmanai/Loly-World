using UnityEngine;
using System.Collections;

public class BlueLockController : MonoBehaviour
{
  public  GameObject animation;
    Animator anim;

    void Start()
    {

        anim = animation.GetComponent<Animator>();
        anim.speed = 0;
    }
    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "Finish")
        {

            if (!playerController.Dead)
            {

              

                if (PlayerPrefs.GetInt("CurrentBkeys", 0) > 0)
                {


                    Invoke("startanimation", 0.1f);
                 
               

                }
            }


        }
    }

    public void startanimation()
    {


        if (PlayerPrefs.GetInt("Sound", 1) == 1)
        {
            GameObject.Find("LockSound").GetComponent<AudioSource>().Play();

        }
       
        if (PlayerPrefs.GetInt("SelectedLevel", 1) == 16)
        {
            animation.SetActive(true);
            anim.speed = 1;

            anim.Play("explosion4");
            gameObject.SetActive(false);
            Invoke("stopanim", 0.2f);

        }
        else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 17)
        {
            animation.SetActive(true);
            anim.speed = 1;

            anim.Play("explosion4");
            gameObject.SetActive(false);
            Invoke("stopanim", 0.2f);

        }
        else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 19)
        {
            animation.SetActive(true);
            anim.speed = 1;

            anim.Play("explosion4");
            gameObject.SetActive(false);
            Invoke("stopanim", 0.2f);

        }
        else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 21)
        {
            animation.SetActive(true);
            anim.speed = 1;

            anim.Play("explosion4");
            gameObject.SetActive(false);
            Invoke("stopanim", 0.2f);

        }
        else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 28)
        {
            animation.SetActive(true);
            anim.speed = 1;

            anim.Play("explosion4");
            gameObject.SetActive(false);
            Invoke("stopanim", 0.2f);

        }
        else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 29)
        {
            animation.SetActive(true);
            anim.speed = 1;

            anim.Play("explosion4");
            gameObject.SetActive(false);
            Invoke("stopanim", 0.2f);

        }
        else if (PlayerPrefs.GetInt("SelectedLevel", 1) == 30)
        {
            animation.SetActive(true);
            anim.speed = 1;

            anim.Play("explosion4");
            gameObject.SetActive(false);
            Invoke("stopanim", 0.2f);

        }
        else
        {

            animation.SetActive(true);
            anim.speed = 1;

            anim.Play("explosion2");
            gameObject.SetActive(false);
            Invoke("stopanim", 0.2f);
        }
    }
    public void stopanim()
    {


        animation.SetActive(false);
        anim.speed = 0;
    }



}
